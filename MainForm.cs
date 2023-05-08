using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using Viewer3D.Components.CanvasComponents;
using Viewer3D.Components.MeshComponents;
using Viewer3D.Components.STLComponents;
using Vector2 = System.Numerics.Vector2;

namespace Viewer3D
{
    public partial class MainForm : Form
    {
        private bool isFirstMouseHold = true;
        private Vector2 lastMousePosition;
        private Canvas canvas;
        private List<Mesh> grains = new List<Mesh>();

        public MainForm()
        {
            InitializeComponent();
            lastMousePosition = Vector2.Zero;
            canvas = new Canvas(glControl, toggleWireframeCheckbox);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Mesh mesh;

                var filestream = openFileDialog1.OpenFile();

                if (!STLWrapper.TryParseSTLFile(filestream, out mesh))
                {
                    showErrorMessageBox("Erro na leitura do arquivo. Tente novamente ou utilize outro arquivo.");
                    return;
                }

                mesh.MoveToOrigin();
                canvas.drawingQueue.Add(mesh);
                canvas.UpdateScalingFactor();
                canvas.Render();

                volumeTextBox.Text = mesh.Volume.ToString();
            }
        }

        private void showErrorMessageBox(string message)
        {
            string caption = "Erro";
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            glControl.Resize += glControl_Resize;
            glControl.Paint += glControl_Paint;
            glControl.MouseWheel += glControl_MouseWheel;

            canvas.lighting.EnableAmbientDiffuseLighting();
            canvas.Render();

            // Ensure that the viewport and projection matrix are set correctly initially.
            glControl_Resize(glControl, EventArgs.Empty);
        }

        private void glControl_Resize(object sender, EventArgs e)
        {
            glControl.MakeCurrent();

            if (glControl.ClientSize.Height == 0)
                glControl.ClientSize = new System.Drawing.Size(glControl.ClientSize.Width, 1);

            GL.Viewport(0, 0, glControl.ClientSize.Width, glControl.ClientSize.Height);

            float aspect_ratio = Math.Max(glControl.ClientSize.Width, 1) / (float)Math.Max(glControl.ClientSize.Height, 1);
            Matrix4 perpective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perpective);
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            canvas.Render();
        }

        private void glControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                isFirstMouseHold = true;
                glControl.MouseMove += glControl_MouseMove;
            }
        }

        private void glControl_MouseUp(object sender, MouseEventArgs e)
        {
            isFirstMouseHold = false;
            glControl.MouseMove -= glControl_MouseMove;
        }

        private void glControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFirstMouseHold)
            {
                isFirstMouseHold = false;

                UpdateLastMousePosition(e.Location);
            }

            float deltaX = e.X - lastMousePosition.X;
            float deltaY = e.Y - lastMousePosition.Y;

            canvas.camera.UpdateYaw(deltaX);
            canvas.camera.UpdatePitch(deltaY);

            UpdateLastMousePosition(e.Location);

            canvas.Render();
        }

        private void glControl_MouseWheel(object sender, MouseEventArgs e)
        {
            canvas.camera.UpdateZoomMultiplier(-e.Delta);
            canvas.Render();
        }

        private void UpdateLastMousePosition(Point newPoint)
        {
            lastMousePosition.X = newPoint.X;
            lastMousePosition.Y = newPoint.Y;
        }

        private void resetRotationButton_Click(object sender, EventArgs e)
        {
            canvas.camera.ResetPitch();
            canvas.camera.ResetYaw();
            canvas.Render();
        }

        private void resetZoomButton_Click(object sender, EventArgs e)
        {
            canvas.camera.ResetZoom();
            canvas.Render();
        }

        private void toggleWireframeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Render();
        }

        private void toggleLightingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            toggleLightingCheckbox_Split.Checked = checkbox.Checked;

            toggleLighting_ContextMenu_AmbientDiffuse.CheckedChanged -= toggleLighting_ContextMenu_AmbientDiffuse_CheckedChanged;
            toggleLighting_ContextMenu_AmbientDiffuse.Checked = checkbox.Checked;
            toggleLighting_ContextMenu_AmbientDiffuse.CheckedChanged += toggleLighting_ContextMenu_AmbientDiffuse_CheckedChanged;

            if (checkbox.Checked)
                checkbox.BackgroundImage = Properties.Resources.bulb_light_on_235x256;

            else
            {
                checkbox.BackgroundImage = Properties.Resources.bulb_light_off_235x256;
                toggleLighting_ContextMenu_Specular.Checked = checkbox.Checked;
            }


            canvas.lighting.ToggleAmbientDiffuseLighting(checkbox.Checked);
            canvas.Render();
        }

        private void toggleLighting_ContextMenu_Specular_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem specular = (ToolStripMenuItem)sender;

            if (specular.Checked)
            {
                toggleLighting_ContextMenu_AmbientDiffuse.Checked = specular.Checked;
                toggleLightingCheckbox.Checked = specular.Checked;
            }

            canvas.lighting.ToggleSpecularLighting(specular.Checked);
            canvas.Render();
        }

        private void toggleLighting_ContextMenu_AmbientDiffuse_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem ambientDiffuse = (ToolStripMenuItem)sender;

            toggleLightingCheckbox.Checked = ambientDiffuse.Checked;
        }

        private void toggleLightingCheckbox_Split_MouseClick(object sender, MouseEventArgs e)
        {
            toggleLighting_ContextMenu.Show((Control)toggleLightingCheckbox_Split, e.Location);
        }

        private void colorLighting_Click(object sender, EventArgs e)
        {
            var lightingColorForm = new LightingColorForm(  canvas.lighting.LightAmbientColor,
                                                            canvas.lighting.LightDiffuseColor,
                                                            canvas.lighting.LightSpecularColor);

            if (lightingColorForm.ShowDialog() != DialogResult.OK)
                return;

            canvas.lighting.LightAmbientColor = lightingColorForm.ambientColorButton.BackColor;
            canvas.lighting.LightDiffuseColor = lightingColorForm.diffuseColorButton.BackColor;
            canvas.lighting.LightSpecularColor = lightingColorForm.specularColorButton.BackColor;
            canvas.lighting.RefreshLightingColor();
            canvas.Render();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(canvas.BackgroundColor,
                                                canvas.WireframeColor);

            if (settingsForm.ShowDialog() != DialogResult.OK)
                return;

            canvas.BackgroundColor = settingsForm.BackgroundColorButton.BackColor;
            canvas.WireframeColor = settingsForm.wireframeColorButton.BackColor;
            canvas.Render();
        }

        private void settingsContainer_Resize()
        {
            var settingsContainerHeight = optionsPanel.Height -
                                    resetRotationButton.Height -
                                    resetZoomButton.Height -
                                    toggleLightingCheckbox.Height -
                                    toggleWireframeCheckbox.Height - 7;

            settingsContainer.Height = settingsContainerHeight;
        }

        private void optionsPanel_Resize(object sender, EventArgs e)
        {
            settingsContainer_Resize();   
        }
    }
}
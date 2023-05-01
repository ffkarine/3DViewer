using OpenTK.WinForms;

namespace Viewer3D
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.glControl = new OpenTK.WinForms.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resetRotationButton = new System.Windows.Forms.Button();
            this.resetZoomButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toggleWireframeCheckbox = new System.Windows.Forms.CheckBox();
            this.toggleLightingCheckbox = new System.Windows.Forms.CheckBox();
            this.toggleLighting_ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleLighting_ContextMenu_AmbientDiffuse = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleLighting_ContextMenu_Specular = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleLightingCheckbox_Split = new System.Windows.Forms.CheckBox();
            this.optionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.volumeUnitLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1.SuspendLayout();
            this.toggleLighting_ContextMenu.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.volumePanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            this.glControl.APIVersion = new System.Version(3, 3, 0, 0);
            this.glControl.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            this.glControl.IsEventDriven = true;
            this.glControl.Location = new System.Drawing.Point(51, 28);
            this.glControl.Margin = new System.Windows.Forms.Padding(0);
            this.glControl.Name = "glControl";
            this.glControl.Profile = OpenTK.Windowing.Common.ContextProfile.Compatability;
            this.glControl.Size = new System.Drawing.Size(853, 401);
            this.glControl.TabIndex = 2;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.openToolStripMenuItem.Text = "Import...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "STL Files|*.stl";
            // 
            // resetRotationButton
            // 
            this.resetRotationButton.AccessibleDescription = "Reset rotation";
            this.resetRotationButton.AccessibleName = "Reset rotation";
            this.resetRotationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetRotationButton.BackgroundImage = global::Viewer3D.Properties.Resources.reset_256x224;
            this.resetRotationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetRotationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.resetRotationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetRotationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetRotationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetRotationButton.Location = new System.Drawing.Point(0, 0);
            this.resetRotationButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetRotationButton.Name = "resetRotationButton";
            this.resetRotationButton.Size = new System.Drawing.Size(50, 38);
            this.resetRotationButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.resetRotationButton, "Reset rotation");
            this.resetRotationButton.UseVisualStyleBackColor = true;
            this.resetRotationButton.Click += new System.EventHandler(this.resetRotationButton_Click);
            // 
            // resetZoomButton
            // 
            this.resetZoomButton.AccessibleDescription = "Reset zoom";
            this.resetZoomButton.AccessibleName = "Reset zoom";
            this.resetZoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetZoomButton.BackgroundImage = global::Viewer3D.Properties.Resources.zoom_reset_256x256;
            this.resetZoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetZoomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.resetZoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetZoomButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetZoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetZoomButton.Location = new System.Drawing.Point(0, 38);
            this.resetZoomButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetZoomButton.Name = "resetZoomButton";
            this.resetZoomButton.Size = new System.Drawing.Size(50, 38);
            this.resetZoomButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.resetZoomButton, "Reset zoom");
            this.resetZoomButton.UseVisualStyleBackColor = true;
            this.resetZoomButton.Click += new System.EventHandler(this.resetZoomButton_Click);
            // 
            // toggleWireframeCheckbox
            // 
            this.toggleWireframeCheckbox.AccessibleDescription = "Toggle wireframe";
            this.toggleWireframeCheckbox.AccessibleName = "Toggle wireframe";
            this.toggleWireframeCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleWireframeCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleWireframeCheckbox.BackgroundImage = global::Viewer3D.Properties.Resources.wireframe_256x256;
            this.toggleWireframeCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggleWireframeCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleWireframeCheckbox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.toggleWireframeCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toggleWireframeCheckbox.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toggleWireframeCheckbox.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toggleWireframeCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleWireframeCheckbox.Location = new System.Drawing.Point(0, 76);
            this.toggleWireframeCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.toggleWireframeCheckbox.Name = "toggleWireframeCheckbox";
            this.toggleWireframeCheckbox.Size = new System.Drawing.Size(50, 38);
            this.toggleWireframeCheckbox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.toggleWireframeCheckbox, "Toggle wireframe");
            this.toggleWireframeCheckbox.UseVisualStyleBackColor = true;
            this.toggleWireframeCheckbox.CheckedChanged += new System.EventHandler(this.toggleWireframeCheckbox_CheckedChanged);
            // 
            // toggleLightingCheckbox
            // 
            this.toggleLightingCheckbox.AccessibleDescription = "Toggle lighting";
            this.toggleLightingCheckbox.AccessibleName = "Toggle lighting";
            this.toggleLightingCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleLightingCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleLightingCheckbox.BackgroundImage = global::Viewer3D.Properties.Resources.bulb_light_on_235x256;
            this.toggleLightingCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggleLightingCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleLightingCheckbox.Checked = true;
            this.toggleLightingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleLightingCheckbox.ContextMenuStrip = this.toggleLighting_ContextMenu;
            this.toggleLightingCheckbox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.toggleLightingCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toggleLightingCheckbox.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toggleLightingCheckbox.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toggleLightingCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleLightingCheckbox.Location = new System.Drawing.Point(0, 0);
            this.toggleLightingCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.toggleLightingCheckbox.Name = "toggleLightingCheckbox";
            this.toggleLightingCheckbox.Size = new System.Drawing.Size(40, 38);
            this.toggleLightingCheckbox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.toggleLightingCheckbox, "Toggle lighting");
            this.toggleLightingCheckbox.UseVisualStyleBackColor = true;
            this.toggleLightingCheckbox.CheckedChanged += new System.EventHandler(this.toggleLightingCheckbox_CheckedChanged);
            // 
            // toggleLighting_ContextMenu
            // 
            this.toggleLighting_ContextMenu.AutoSize = false;
            this.toggleLighting_ContextMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toggleLighting_ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleLighting_ContextMenu_AmbientDiffuse,
            this.toggleLighting_ContextMenu_Specular});
            this.toggleLighting_ContextMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toggleLighting_ContextMenu.Name = "contextMenuStrip1";
            this.toggleLighting_ContextMenu.Size = new System.Drawing.Size(35, 62);
            // 
            // toggleLighting_ContextMenu_AmbientDiffuse
            // 
            this.toggleLighting_ContextMenu_AmbientDiffuse.AccessibleDescription = "Toggle ambient/diffuse lighting";
            this.toggleLighting_ContextMenu_AmbientDiffuse.AccessibleName = "Toggle ambient/diffuse lighting";
            this.toggleLighting_ContextMenu_AmbientDiffuse.AutoSize = false;
            this.toggleLighting_ContextMenu_AmbientDiffuse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggleLighting_ContextMenu_AmbientDiffuse.Checked = true;
            this.toggleLighting_ContextMenu_AmbientDiffuse.CheckOnClick = true;
            this.toggleLighting_ContextMenu_AmbientDiffuse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleLighting_ContextMenu_AmbientDiffuse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleLighting_ContextMenu_AmbientDiffuse.Image = global::Viewer3D.Properties.Resources.sun_256x256;
            this.toggleLighting_ContextMenu_AmbientDiffuse.Name = "toggleLighting_ContextMenu_AmbientDiffuse";
            this.toggleLighting_ContextMenu_AmbientDiffuse.ShowShortcutKeys = false;
            this.toggleLighting_ContextMenu_AmbientDiffuse.Size = new System.Drawing.Size(34, 29);
            this.toggleLighting_ContextMenu_AmbientDiffuse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toggleLighting_ContextMenu_AmbientDiffuse.ToolTipText = "Toggle ambient/diffuse lighting";
            this.toggleLighting_ContextMenu_AmbientDiffuse.CheckedChanged += new System.EventHandler(this.toggleLighting_ContextMenu_AmbientDiffuse_CheckedChanged);
            // 
            // toggleLighting_ContextMenu_Specular
            // 
            this.toggleLighting_ContextMenu_Specular.AccessibleDescription = "Toggle specular lighting";
            this.toggleLighting_ContextMenu_Specular.AccessibleName = "Toggle specular lighting";
            this.toggleLighting_ContextMenu_Specular.AutoSize = false;
            this.toggleLighting_ContextMenu_Specular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggleLighting_ContextMenu_Specular.CheckOnClick = true;
            this.toggleLighting_ContextMenu_Specular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleLighting_ContextMenu_Specular.Image = global::Viewer3D.Properties.Resources.flashlighton_256x254;
            this.toggleLighting_ContextMenu_Specular.Name = "toggleLighting_ContextMenu_Specular";
            this.toggleLighting_ContextMenu_Specular.ShowShortcutKeys = false;
            this.toggleLighting_ContextMenu_Specular.Size = new System.Drawing.Size(34, 29);
            this.toggleLighting_ContextMenu_Specular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toggleLighting_ContextMenu_Specular.ToolTipText = "Toggle specular lighting";
            this.toggleLighting_ContextMenu_Specular.CheckedChanged += new System.EventHandler(this.toggleLighting_ContextMenu_Specular_CheckedChanged);
            // 
            // toggleLightingCheckbox_Split
            // 
            this.toggleLightingCheckbox_Split.AccessibleDescription = "Lighting options";
            this.toggleLightingCheckbox_Split.AccessibleName = "Lighting options";
            this.toggleLightingCheckbox_Split.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleLightingCheckbox_Split.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleLightingCheckbox_Split.AutoCheck = false;
            this.toggleLightingCheckbox_Split.BackColor = System.Drawing.SystemColors.Control;
            this.toggleLightingCheckbox_Split.BackgroundImage = global::Viewer3D.Properties.Resources.down_arrow_256x100;
            this.toggleLightingCheckbox_Split.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toggleLightingCheckbox_Split.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleLightingCheckbox_Split.Checked = true;
            this.toggleLightingCheckbox_Split.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleLightingCheckbox_Split.ContextMenuStrip = this.toggleLighting_ContextMenu;
            this.toggleLightingCheckbox_Split.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.toggleLightingCheckbox_Split.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toggleLightingCheckbox_Split.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toggleLightingCheckbox_Split.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toggleLightingCheckbox_Split.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleLightingCheckbox_Split.Location = new System.Drawing.Point(39, 0);
            this.toggleLightingCheckbox_Split.Margin = new System.Windows.Forms.Padding(0);
            this.toggleLightingCheckbox_Split.Name = "toggleLightingCheckbox_Split";
            this.toggleLightingCheckbox_Split.Size = new System.Drawing.Size(11, 38);
            this.toggleLightingCheckbox_Split.TabIndex = 11;
            this.toolTip1.SetToolTip(this.toggleLightingCheckbox_Split, "Lighting options");
            this.toggleLightingCheckbox_Split.UseVisualStyleBackColor = false;
            this.toggleLightingCheckbox_Split.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toggleLightingCheckbox_Split_MouseClick);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.resetRotationButton);
            this.optionsPanel.Controls.Add(this.resetZoomButton);
            this.optionsPanel.Controls.Add(this.toggleWireframeCheckbox);
            this.optionsPanel.Controls.Add(this.panel1);
            this.optionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optionsPanel.Location = new System.Drawing.Point(0, 28);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(50, 401);
            this.optionsPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toggleLightingCheckbox_Split);
            this.panel1.Controls.Add(this.toggleLightingCheckbox);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 38);
            this.panel1.TabIndex = 13;
            // 
            // volumePanel
            // 
            this.volumePanel.AutoSize = true;
            this.volumePanel.Controls.Add(this.volumeLabel);
            this.volumePanel.Controls.Add(this.volumeTextBox);
            this.volumePanel.Controls.Add(this.volumeUnitLabel);
            this.volumePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumePanel.Location = new System.Drawing.Point(10, 3);
            this.volumePanel.Name = "volumePanel";
            this.volumePanel.Size = new System.Drawing.Size(266, 61);
            this.volumePanel.TabIndex = 15;
            // 
            // volumeLabel
            // 
            this.volumeLabel.Location = new System.Drawing.Point(0, 0);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(62, 27);
            this.volumeLabel.TabIndex = 8;
            this.volumeLabel.Text = "Volume:";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Enabled = false;
            this.volumeTextBox.Location = new System.Drawing.Point(62, 0);
            this.volumeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.ReadOnly = true;
            this.volumeTextBox.Size = new System.Drawing.Size(163, 27);
            this.volumeTextBox.TabIndex = 7;
            // 
            // volumeUnitLabel
            // 
            this.volumeUnitLabel.Location = new System.Drawing.Point(228, 0);
            this.volumeUnitLabel.Name = "volumeUnitLabel";
            this.volumeUnitLabel.Size = new System.Drawing.Size(35, 27);
            this.volumeUnitLabel.TabIndex = 9;
            this.volumeUnitLabel.Text = "m³";
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.infoPanel.ColumnCount = 5;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoPanel.Controls.Add(this.splitter2, 2, 0);
            this.infoPanel.Controls.Add(this.volumePanel, 1, 0);
            this.infoPanel.Controls.Add(this.splitter1, 0, 0);
            this.infoPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.infoPanel.Location = new System.Drawing.Point(0, 432);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 1;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoPanel.Size = new System.Drawing.Size(910, 67);
            this.infoPanel.TabIndex = 14;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitter2.Location = new System.Drawing.Point(282, 3);
            this.splitter2.MaximumSize = new System.Drawing.Size(1, 60);
            this.splitter2.MinimumSize = new System.Drawing.Size(1, 60);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1, 60);
            this.splitter2.TabIndex = 21;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.MaximumSize = new System.Drawing.Size(1, 60);
            this.splitter1.MinimumSize = new System.Drawing.Size(1, 60);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 60);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 499);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.glControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Viewer3D";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toggleLighting_ContextMenu.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.volumePanel.ResumeLayout(false);
            this.volumePanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GLControl glControl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Button resetRotationButton;
        private Button resetZoomButton;
        private ToolTip toolTip1;
        private CheckBox toggleWireframeCheckbox;
        private CheckBox toggleLightingCheckbox;
        private ContextMenuStrip toggleLighting_ContextMenu;
        private ToolStripMenuItem toggleLighting_ContextMenu_AmbientDiffuse;
        private ToolStripMenuItem toggleLighting_ContextMenu_Specular;
        private CheckBox toggleLightingCheckbox_Split;
        private FlowLayoutPanel optionsPanel;
        private Panel panel1;
        private FlowLayoutPanel volumePanel;
        private Label volumeLabel;
        private TextBox volumeTextBox;
        private Label volumeUnitLabel;
        private TableLayoutPanel infoPanel;
        private Splitter splitter2;
        private Splitter splitter1;
    }
}
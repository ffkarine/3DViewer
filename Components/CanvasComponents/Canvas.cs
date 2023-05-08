using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.WinForms;
using Viewer3D.Extensions;
using Viewer3D.Components.MeshComponents;

namespace Viewer3D.Components.CanvasComponents
{
    public class Canvas
    {
        private OpenTK.Mathematics.Vector3 eye;
        private readonly GLControl glControl;
        private readonly CheckBox toggleWireframeCheckbox;

        public Color4 BackgroundColor { get; set; }
        public Color4 WireframeColor { get; set; }
        public double ScalingFactor { get; private set; }
        public Camera camera;
        public Lighting lighting;
        public List<Mesh> drawingQueue;

        public Canvas(GLControl glControl, CheckBox toggleWireframeCheckbox)
        {
            this.glControl = glControl;
            this.toggleWireframeCheckbox = toggleWireframeCheckbox;

            BackgroundColor = Color4.MidnightBlue;
            WireframeColor = Color4.Black;

            drawingQueue = new List<Mesh>();
            camera = new Camera();

            lighting = new Lighting(
                camera: camera,
                lightAmbientColor: Color4.DarkGray,
                lightDiffuseColor: Color4.Gray,
                lightSpecularColor: Color4.White,
                lightSpecularReflection: new Vector4(0.5f, 0.5f, 0.5f, 1.0f),
                lightSpecularShininess: 32
            );
        }

        public void Render()
        {
            glControl.MakeCurrent();

            GL.ClearColor(BackgroundColor);
            GL.Enable(EnableCap.DepthTest);

            eye = camera.GetEye().ToOpenTKVector3();

            Matrix4 lookat = Matrix4.LookAt(
                eye,
                OpenTK.Mathematics.Vector3.Zero,
                OpenTK.Mathematics.Vector3.UnitY
                );

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            foreach (Mesh mesh in drawingQueue) 
                DrawSolid(mesh, Color4.Gray);

            if (toggleWireframeCheckbox.Checked)
            {       
                foreach (Mesh mesh in drawingQueue)
                    DrawWireframe(mesh, WireframeColor);
            }

            glControl.SwapBuffers();
        }

        public void UpdateScalingFactor()
        {
            double scaleFactor = 0;
            List<float> extremes = new List<float>();

            string extreme = ((int)drawingQueue.Max(x => x.FindExtremeCoordinate())).ToString();

            // Finds the place value of the largest absolute coordinate found in the objects and gets the place that,
            // multiplied by this place value found, results in the scale of ones.
            // It is inverted to make the calculations that use it easier.
            scaleFactor = 1 / Math.Pow(10, extreme.Length - 1);

            ScalingFactor = scaleFactor;
        }

        private void DrawSolid(Mesh part, Color4 partColor)
        {
            GL.Color4(partColor);

            foreach (Triangle t in part.Triangles)
            {
                GL.Begin(PrimitiveType.Triangles);
                GL.Normal3(t.Normal.ToOpenTKVector3());
                GL.Vertex3(t.Vertex1.X * ScalingFactor, t.Vertex1.Y * ScalingFactor, t.Vertex1.Z * ScalingFactor);
                GL.Vertex3(t.Vertex2.X * ScalingFactor, t.Vertex2.Y * ScalingFactor, t.Vertex2.Z * ScalingFactor);
                GL.Vertex3(t.Vertex3.X * ScalingFactor, t.Vertex3.Y * ScalingFactor, t.Vertex3.Z * ScalingFactor);
                GL.End();
            }
        }

        private void DrawWireframe(Mesh part, Color4 partColor)
        {
            foreach (Triangle t in part.Triangles)
            {
                GL.Begin(PrimitiveType.LineLoop);
                GL.Color4(partColor);
                GL.Vertex3(t.Vertex1.X * ScalingFactor, t.Vertex1.Y * ScalingFactor, t.Vertex1.Z * ScalingFactor);
                GL.Vertex3(t.Vertex2.X * ScalingFactor, t.Vertex2.Y * ScalingFactor, t.Vertex2.Z * ScalingFactor);
                GL.Vertex3(t.Vertex3.X * ScalingFactor, t.Vertex3.Y * ScalingFactor, t.Vertex3.Z * ScalingFactor);
                GL.End();
            }
        }
    }
}

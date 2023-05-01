using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using Viewer3D.Extensions;

namespace Viewer3D.Components.CanvasComponents
{
    public class Lighting
    {
        private readonly Color4 materialAmbientDefault = new Color4(0.2f, 0.2f, 0.2f, 1.0f);
        private readonly Color4 materialDiffuseDefault = new Color4(0.8f, 0.8f, 0.8f, 1.0f);
        private readonly Color4 lightSpecularColorDefault = new Color4(1.0f, 1.0f, 1.0f, 1.0f);
        private readonly Color4 lightSpecularReflectionDefault = new Color4(0.0f, 0.0f, 0.0f, 1.0f);
        private const int lightSpecularShininessDefault = 0;
        private const int lightSpecularShininessMin = 1;
        private const int lightSpecularShininessMax = 128;

        private int _lightSpecularShininess;
        private readonly Camera camera;

        public Color4 LightAmbientColor { get; set; }
        public Color4 LightDiffuseColor { get; set; }
        public Color4 LightSpecularColor { get; set; }
        public Vector4 LightSpecularReflection { get; set; }
        public Vector3 LightPosition { get; set; }

        public int LightSpecularShininess
        {
            get
            {
                return _lightSpecularShininess;
            }

            set
            {
                _lightSpecularShininess = Math.Clamp(value, lightSpecularShininessMin, lightSpecularShininessMax);
            }
        }

        public Lighting(Camera camera, Color4 lightAmbientColor, Color4 lightDiffuseColor, Color4 lightSpecularColor, Vector4 lightSpecularReflection, int lightSpecularShininess)
        {
            this.camera = camera;
            this.LightAmbientColor = lightAmbientColor;
            this.LightDiffuseColor = lightDiffuseColor;
            this.LightSpecularColor = lightSpecularColor;
            this.LightSpecularReflection = lightSpecularReflection;
            this.LightSpecularShininess = lightSpecularShininess;
        }

        public void ToggleAmbientDiffuseLighting(bool enabled)
        {
            if (enabled)
                EnableAmbientDiffuseLighting();

            else
                DisableLighting();
        }

        public void ToggleSpecularLighting(bool enabled)
        {
            if (enabled)
                SetupSpecularLighting();

            else
                DisableSpecularLighting();
        }
        public void EnableAmbientDiffuseLighting()
        {
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.ColorMaterial);

            SetupAmbientLighting();
            SetupDiffuseLighting();
            SetupLightingPosition(camera.GetEye().ToOpenTKVector3());
        }

        public void DisableLighting()
        {
            GL.Disable(EnableCap.Light0);
            GL.Disable(EnableCap.Lighting);
        }

        private void SetupAmbientLighting()
        {
            GL.Light(LightName.Light0, LightParameter.Ambient, LightAmbientColor);
        }

        private void SetupDiffuseLighting()
        {
            GL.Light(LightName.Light0, LightParameter.Diffuse, LightDiffuseColor);
        }

        private void SetupSpecularLighting()
        {
            SetupSpecularMaterials();
            GL.Light(LightName.Light0, LightParameter.Specular, LightSpecularColor);
        }

        private void DisableSpecularLighting()
        {
            DisableSpecularMaterials();
            GL.Light(LightName.Light0, LightParameter.Specular, lightSpecularColorDefault);
        }

        private void SetupLightingPosition(Vector3 pos)
        {
            GL.Light(LightName.Light0, LightParameter.Position, new Vector4(pos, 1.0f));
        }

        private void SetupSpecularMaterials()
        {
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, LightSpecularReflection);
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, LightSpecularShininess);
        }

        private void DisableSpecularMaterials()
        {
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, materialAmbientDefault);
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, materialDiffuseDefault);
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, lightSpecularReflectionDefault);
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, lightSpecularShininessDefault);
        }
    }
}

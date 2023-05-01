using OpenTK.Mathematics;
using Vector3 = System.Numerics.Vector3;

namespace Viewer3D.Components.CanvasComponents
{
    public class Camera
    {
        private const float RotationConstraint = 89.0f;
        private const float ZoomConstraintMin = 5.0f;
        private const float ZoomConstraintMax = 50.0f;
        public float MouseSensitivity { get; }
        public float WheelSensitivity { get; }
        public float Yaw { get; private set; }
        public float Pitch { get; private set; }
        public float ZoomMultiplier { get; private set; }

        public Camera()
        {
            MouseSensitivity = 0.5f;
            WheelSensitivity = 0.0075f;
            ResetZoom();
            ResetYaw();
            ResetPitch();
        }

        public void ResetYaw()
        {
            Yaw = 0.0f;
        }

        public void ResetPitch()
        {
            Pitch = 0.0f;
        }

        public void ResetZoom()
        {
            ZoomMultiplier = 10.0f;
        }

        public void UpdateYaw(float deltaX)
        {
            Yaw += deltaX * MouseSensitivity;
        }

        public void UpdatePitch(float deltaY)
        {
            Pitch += deltaY * MouseSensitivity;
            Pitch = Math.Clamp(Pitch, -RotationConstraint, RotationConstraint);
        }

        public void UpdateZoomMultiplier(float increment)
        {
            ZoomMultiplier += increment * WheelSensitivity;
            ZoomMultiplier = Math.Clamp(ZoomMultiplier, ZoomConstraintMin, ZoomConstraintMax);
        }

        public Vector3 GetEye()
        {
            Vector3 eye = new Vector3(
                (float)Math.Cos(MathHelper.DegreesToRadians(Pitch)) * (float)Math.Cos(MathHelper.DegreesToRadians(Yaw)),
                (float)Math.Sin(MathHelper.DegreesToRadians(Pitch)),
                (float)Math.Cos(MathHelper.DegreesToRadians(Pitch)) * (float)Math.Sin(MathHelper.DegreesToRadians(Yaw))
            );

            return eye * ZoomMultiplier;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Viewer3D.Extensions
{
    public static class Extensions_Vector3
    {
        public static Vector3 MoveVertex(this Vector3 vertex, Vector3 distance)
        {
            return vertex - distance;
        }

        public static OpenTK.Mathematics.Vector3 ToOpenTKVector3(this Vector3 vector3)
        {
            OpenTK.Mathematics.Vector3 openTKVector3;

            openTKVector3.X = vector3.X;
            openTKVector3.Y = vector3.Y;
            openTKVector3.Z = vector3.Z;

            return openTKVector3;
        }

        public static bool isNaN(this Vector3 vector3)
        {
            if (Single.IsNaN(vector3.X) || Single.IsNaN(vector3.Y) || Single.IsNaN(vector3.Z))
                return true;

            return false;
        }
    }
}

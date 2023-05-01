using System.Diagnostics;
using System.Numerics;
using Viewer3D.Components.MeshComponents;

namespace Viewer3D.Components.STLComponents
{
    public static class BinarySTLReader
    {
        private const int HeaderSize = 80;
        private const int TriangleNumberSize = 4;
        private const int CoordinateSize = 4;
        private const int AttributeByteCount = 2;

        public static bool TryParseBinarySTLFile(BinaryReader br, out Mesh mesh)
        {
            int triangleNumber;
            List<Triangle> auxTriangles = new List<Triangle>();

            try
            {
                ReadHeader(br);

                triangleNumber = ReadTriangleNumber(br);

                for (int i = 0; i < triangleNumber; i++)
                {
                    auxTriangles.Add(ReadTriangle(br));
                }
            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
                mesh = null;
                return false;
            }

            mesh = new Mesh(auxTriangles);

            return true;
        }
        private static void ReadHeader(BinaryReader br)
        {
            br.ReadBytes(HeaderSize - STLWrapper.ASCIIPrefixSize);
        }

        private static int ReadTriangleNumber(BinaryReader br)
        {
            byte[] triangleNumberBuffer = br.ReadBytes(TriangleNumberSize);

            if (!BitConverter.IsLittleEndian)
                Array.Reverse(triangleNumberBuffer);

            int triangleNumber = BitConverter.ToInt32(triangleNumberBuffer, 0);

            return triangleNumber;
        }

        private static Triangle ReadTriangle(BinaryReader br)
        {
            Vector3 normal = ReadPoint(br);
            Vector3 v1 = ReadPoint(br);
            Vector3 v2 = ReadPoint(br);
            Vector3 v3 = ReadPoint(br);

            ReadAttributeByteCount(br);

            return new Triangle(v1, v2, v3, normal);
        }

        private static Vector3 ReadPoint(BinaryReader br)
        {
            Vector3 point = new Vector3();

            byte[] x = br.ReadBytes(CoordinateSize);
            byte[] y = br.ReadBytes(CoordinateSize);
            byte[] z = br.ReadBytes(CoordinateSize);

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(x);
                Array.Reverse(y);
                Array.Reverse(z);
            }

            point.X = BitConverter.ToSingle(x, 0);
            point.Y = BitConverter.ToSingle(y, 0);
            point.Z = BitConverter.ToSingle(z, 0);

            return point;
        }

        private static void ReadAttributeByteCount(BinaryReader br)
        {
            br.ReadBytes(AttributeByteCount);
        }
    }

}

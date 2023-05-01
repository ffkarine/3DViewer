using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using Viewer3D.Components.MeshComponents;

namespace Viewer3D.Components.STLComponents
{
    public static class ASCIISTLReader
    {
        static readonly CultureInfo culture = new CultureInfo("en-US");
        const int fileLinesPerTriangle = 7;

        public static bool TryParseASCIISTLFile(StreamReader sr, out Mesh mesh)
        {
            int counter = 0;
            List<string> triangleFileContent = new List<string>();
            List<Triangle> auxTriangles = new List<Triangle>();

            try
            {
                while (!sr.EndOfStream)
                {
                    if (counter > 0 && counter % fileLinesPerTriangle == 0)
                    {
                        auxTriangles.Add(ReadTriangle(triangleFileContent));
                        triangleFileContent.Clear();
                    }

                    triangleFileContent.Add(sr.ReadLine());
                    counter++;
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

        private static Triangle ReadTriangle(List<string> TriangleFileContent)
        {
            Vector3 normal = ReadNormal(TriangleFileContent[0]);
            Vector3 v1 = ReadVertex(TriangleFileContent[2]);
            Vector3 v2 = ReadVertex(TriangleFileContent[3]);
            Vector3 v3 = ReadVertex(TriangleFileContent[4]);

            return new Triangle(v1, v2, v3, normal);
        }

        private static Vector3 ReadNormal(string normalLine)
        {
            Vector3 normal = new Vector3();

            normalLine = normalLine.Trim('\t', ' ');

            string[] words = normalLine.Split(' ');

            if (words[0] == "facet")
            {
                normal.X = float.Parse(words[2], culture);
                normal.Y = float.Parse(words[3], culture);
                normal.Z = float.Parse(words[4], culture);
            }

            return normal;
        }

        private static Vector3 ReadVertex(string vertexLine)
        {
            Vector3 vertex = new Vector3();

            vertexLine = vertexLine.Trim('\t', ' ');
            string[] words = vertexLine.Split(' ');

            if (words[0] == "vertex")
            {
                vertex.X = float.Parse(words[1], culture);
                vertex.Y = float.Parse(words[2], culture);
                vertex.Z = float.Parse(words[3], culture);
            }

            return vertex;
        }
    }
}

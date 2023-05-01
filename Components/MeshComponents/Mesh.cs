using System.Numerics;

namespace Viewer3D.Components.MeshComponents
{
    public class Mesh
    {
        public List<Triangle> Triangles { get; private set; }
        public float Volume { get; private set; }

        public Mesh(List<Triangle> triangles) 
        {
            this.Triangles = triangles;
            UpdateVolume();
        }

        public void MoveToOrigin()
        {
            float deltaX = FindUpperX() - FindLowerX();
            float deltaY = FindUpperY() - FindLowerY();
            float deltaZ = FindUpperZ() - FindLowerZ();

            Vector3 midCoordinates = new Vector3(FindLowerX() + deltaX / 2, FindLowerY() + deltaY / 2, FindLowerZ() + deltaZ / 2);

            foreach (Triangle t in Triangles)
                t.MoveTriangle(midCoordinates);
        }

        public void UpdateVolume()
        {
            Volume = Math.Abs(Triangles.Sum(t => t.GetTetrahedronSignedVolume()));
        }

        public float FindExtremeCoordinate()
        {
            float extremeX = Math.Abs(FindExtremeX());
            float extremeY = Math.Abs(FindExtremeY());
            float extremeZ = Math.Abs(FindExtremeZ());

            return (new[] { extremeX, extremeY, extremeZ }).Max();
        }

        public float FindExtremeX()
        {
            var verticesXs = Triangles
                .SelectMany(t => new[] { t.Vertex1.X, t.Vertex2.X, t.Vertex3.X }).ToList();

            var absolutes = verticesXs.Select(Math.Abs).ToList();

            // Gets the element in the original list which index matches the index of extreme abs in order to preserve the original signal
            var extreme = verticesXs[absolutes.IndexOf(absolutes.Max())];

            return extreme;
        }

        public float FindExtremeY()
        {
            var verticesYs = Triangles
                .SelectMany(t => new[] { t.Vertex1.Y, t.Vertex2.Y, t.Vertex3.Y }).ToList();

            var absolutes = verticesYs.Select(Math.Abs).ToList();

            // Gets the element in the original list which index matches the index of extreme abs in order to preserve the original signal
            var extreme = verticesYs[absolutes.IndexOf(absolutes.Max())];

            return extreme;
        }

        public float FindExtremeZ()
        {
            var verticesZs = Triangles
                .SelectMany(t => new[] { t.Vertex1.Z, t.Vertex2.Z, t.Vertex3.Z }).ToList();

            var absolutes = verticesZs.Select(Math.Abs).ToList();

            // Gets the element in the original list which index matches the index of extreme abs in order to preserve the original signal
            var extreme = verticesZs[absolutes.IndexOf(absolutes.Max())];

            return extreme;
        }

        private float FindLowerX()
        {
            float min = Triangles
                .SelectMany(t => new[] { t.Vertex1.X, t.Vertex2.X, t.Vertex3.X }).Min();

            return min;
        }

        private float FindLowerY()
        {
            float min = Triangles
                .SelectMany(t => new[] { t.Vertex1.Y, t.Vertex2.Y, t.Vertex3.Y }).Min();

            return min;
        }

        private float FindLowerZ()
        {
            float min = Triangles
                .SelectMany(t => new[] { t.Vertex1.Z, t.Vertex2.Z, t.Vertex3.Z }).Min();

            return min;
        }

        private float FindUpperX()
        {
            float max = Triangles
                .SelectMany(t => new[] { t.Vertex1.X, t.Vertex2.X, t.Vertex3.X }).Max();

            return max;
        }

        private float FindUpperY()
        {
            float max = Triangles
                .SelectMany(t => new[] { t.Vertex1.Y, t.Vertex2.Y, t.Vertex3.Y }).Max();

            return max;
        }

        private float FindUpperZ()
        {
            float max = Triangles
                .SelectMany(t => new[] { t.Vertex1.Z, t.Vertex2.Z, t.Vertex3.Z }).Max();

            return max;
        }
    }
}

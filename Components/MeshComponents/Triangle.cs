using System.Collections;
using System.Numerics;
using Viewer3D.Extensions;

namespace Viewer3D.Components.MeshComponents
{
    public class Triangle : IEnumerable<Vector3>
    {
        public Vector3 Vertex1 { get; private set; }
        public Vector3 Vertex2 { get; private set; }
        public Vector3 Vertex3 { get; private set; }
        public Vector3 Normal { get; private set; }

        public Triangle(Vector3 vertex1, Vector3 vertex2, Vector3 vertex3, Vector3 normal)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;

            Normal = Vector3.Normalize(normal);

            if (Normal.isNaN() || !ValidateVertices())
                throw new Exception("Error building the current triangle. Normal is NaN or there are coincident vertices");
        }

        private bool ValidateVertices()
        {
            if (Vertex1 == Vertex2 || Vertex1 == Vertex3 || Vertex2 == Vertex3)
                return false;

            return true;
        }

        public void MoveTriangle(Vector3 distance)
        {
            Vertex1 = Vertex1.MoveVertex(distance);
            Vertex2 = Vertex2.MoveVertex(distance);
            Vertex3 = Vertex3.MoveVertex(distance);
        }

        public Vector3 GetMidPoint()
        {
            Vector3 midPoint = (Vertex1 + Vertex2 + Vertex3) / 3;
            return midPoint;
        }

        // Treats the triangle as a tetrahedron closed in the origin and calculate its volume.
        // This is used to compute the volume of the object that this triangle belongs to.
        // To understand this better, check: http://chenlab.ece.cornell.edu/Publication/Cha/icip01_Cha.pdf
        public float GetTetrahedronSignedVolume()
        {
            return Vector3.Dot(Vertex1, Vector3.Cross(Vertex2, Vertex3)) / 6.0f ;
        }

        public IEnumerator<Vector3> GetEnumerator()
        {
            yield return Vertex1;
            yield return Vertex2;
            yield return Vertex3;
            yield return Normal;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

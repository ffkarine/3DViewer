using System.Numerics;
using Viewer3D.Components.MeshComponents;

namespace Viewer3D.Components.STLComponents
{
    public static class STLWrapper
    {
        // ASCIIPrefixSize is the number of chars to read in order to test if the file begins with "solid", which means that the file is formatted as ASCII
        public const int ASCIIPrefixSize = 5;

        public static bool TryParseSTLFile(Stream filestream, out Mesh mesh) 
        {
            bool success = false;

            // The file is opened with a BinaryReader because otherwise (opening it as a StreamReader first) makes it not possible to be read as a binary again.
            BinaryReader br = new BinaryReader(filestream);

            if (IsASCIIFile(br))
            {
                StreamReader sr = new StreamReader(filestream);

                // This is called only to read the characters left behind in the first line when reading the [ASCIIPrefixSize] bytes (see the method isASCIIFile)
                sr.ReadLine();

                success = ASCIISTLReader.TryParseASCIISTLFile(sr, out mesh);
                sr.Close();
            }

            else
            {
                success = BinarySTLReader.TryParseBinarySTLFile(br, out mesh);
                br.Close();
            }

            return success;
        }

        private static bool IsASCIIFile(BinaryReader br)
        {
            string aux = new string(br.ReadChars(ASCIIPrefixSize));

            if (aux.StartsWith("solid"))
                return true;

            return false;
        }
    }
}

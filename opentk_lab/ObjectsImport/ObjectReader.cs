using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opentk_lab.ObjectsImport
{
    public class ObjectReader
    {
        public static float[] ReadObj(string path)
        {
            List<Vertex> objVertices = new List<Vertex>();
            List<Texture> objTextures = new List<Texture>();
            List<Normal> objNormals = new List<Normal>();

            List<float> allCoords = new List<float>();

            string fileText = File.ReadAllText(path);
            string[] fileLines = fileText.Split('\n');

            int i = 0;
            for (; i < fileLines.Length; i++)
            {
                string line = fileLines[i];
                string[] lineParts = line.Split(' ');

                if (line.StartsWith("vn"))
                {
                    float x = float.Parse(lineParts[1].Replace('.', ','));
                    float y = float.Parse(lineParts[2].Replace('.', ','));
                    float z = float.Parse(lineParts[3].Replace('.', ','));
                    objNormals.Add(new Normal(x, y, z));
                }
                else if (line.StartsWith("vt"))
                {
                    float x = float.Parse(lineParts[1].Replace('.', ','));
                    float y = float.Parse(lineParts[2].Replace('.', ','));
                    objTextures.Add(new Texture(x, y));
                }
                else if (line.StartsWith("v"))
                {
                    float x = float.Parse(lineParts[1].Replace('.', ','));
                    float y = float.Parse(lineParts[2].Replace('.', ','));
                    float z = float.Parse(lineParts[3].Replace('.', ','));
                    objVertices.Add(new Vertex(x, y, z));
                }

                else if (line.StartsWith("f")) break;
            }

            for (; i < fileLines.Length; i++)
            {
                string line = fileLines[i];
                string[] lineParts = line.Split(' ');

                if (line.StartsWith("f"))
                {
                    string[] s1 = lineParts[1]
                        .Split(new string[] { "/" }, StringSplitOptions.None);
                    string[] s2 = lineParts[2]
                        .Split(new string[] { "/" }, StringSplitOptions.None);
                    string[] s3 = lineParts[3]
                        .Split(new string[] { "/" }, StringSplitOptions.None);

                    int v1 = int.Parse(s1[0]) - 1;
                    int vt1 = int.Parse(s1[1]) - 1;
                    int vn1 = int.Parse(s1[2]) - 1;

                    int v2 = int.Parse(s2[0]) - 1;
                    int vt2 = int.Parse(s2[1]) - 1;
                    int vn2 = int.Parse(s2[2]) - 1;

                    int v3 = int.Parse(s3[0]) - 1;
                    int vt3 = int.Parse(s3[1]) - 1;
                    int vn3 = int.Parse(s3[2]) - 1;

                    allCoords.Add(objVertices[v1].x);
                    allCoords.Add(objVertices[v1].y);
                    allCoords.Add(objVertices[v1].z);
                    allCoords.Add(objTextures[vt1].x);
                    allCoords.Add(objTextures[vt1].y);
                    allCoords.Add(objNormals[vn1].x);
                    allCoords.Add(objNormals[vn1].y);
                    allCoords.Add(objNormals[vn1].z);

                    allCoords.Add(objVertices[v2].x);
                    allCoords.Add(objVertices[v2].y);
                    allCoords.Add(objVertices[v2].z);
                    allCoords.Add(objTextures[vt2].x);
                    allCoords.Add(objTextures[vt2].y);
                    allCoords.Add(objNormals[vn2].x);
                    allCoords.Add(objNormals[vn2].y);
                    allCoords.Add(objNormals[vn2].z);

                    allCoords.Add(objVertices[v3].x);
                    allCoords.Add(objVertices[v3].y);
                    allCoords.Add(objVertices[v3].z);
                    allCoords.Add(objTextures[vt3].x);
                    allCoords.Add(objTextures[vt3].y);
                    allCoords.Add(objNormals[vn3].x);
                    allCoords.Add(objNormals[vn3].y);
                    allCoords.Add(objNormals[vn3].z);
                }
            }
            return allCoords.ToArray();
        }
    }
}

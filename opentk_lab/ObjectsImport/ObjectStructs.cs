using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opentk_lab.ObjectsImport
{
    public struct Vertex
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    
        public Vertex(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    
    public struct Normal
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    
        public Normal(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    
    public struct Texture
    {
        public float x { get; set; }
        public float y { get; set; }
    
        public Texture(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

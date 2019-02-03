using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharpGL;
using GlmNet;

namespace RenderObj
{
    public class Obj
    {
        public string FileName { get; set; }
        public List<vec4> Vertices { get; set; }
        public List<vec3> Normals { get; set; }
        public List<System.Int16> Elements {get; set;} //equivlent to Glushort
    }

    public static class Extension
    {
        public static Stream ToStream(this string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }   

    public class ObjReader
    {
        public static Obj GetObjFromFile(string fileName)
        {
            var obj = new Obj();
            int counter = 0;
            string line;
            using (var file = new StreamReader($@"{fileName}"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Substring(0,2) == "v ")
                    {
                        //obj.Vertices.Add(line.Substring(2))
                        using (var stringStream = line.Substring(2).ToStream())
                        {
                        
                        }
                    }
                    else if (line.Substring(0, 2) == "f ")
                    {

                    }
                    counter++;
                }
            }

            return new Obj();
        }
    }
}

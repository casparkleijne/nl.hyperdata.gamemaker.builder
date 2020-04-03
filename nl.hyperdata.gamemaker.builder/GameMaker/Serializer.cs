using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nl.hyperdata.gamemaker.builder.GameMaker
{
    internal class Serializer
    {
        public static JObject Deserialize(string path)
        {       
            string json = File.ReadAllText(path);
            return JObject.Parse(json);
        }

        public static bool Serialize(string path, object data)
        {
            string json = JsonConvert.SerializeObject(data,Formatting.Indented);
            File.WriteAllText(path,json);
            return true;
        }

    }
}

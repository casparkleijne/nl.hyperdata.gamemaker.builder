using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;

namespace nl.hyperdata.gamemaker.yy.IO
{
    public class Serializer
    {

        public static async Task<JObject> Deserialize(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                throw new System.ArgumentException("invalid json", nameof(json));
            }

            return await Task.Run(() => JObject.Parse(json));
        }

        public static async Task<string> Serialize(JObject data)
        {
            if (data is null)
            {
                throw new ArgumentNullException("invalid JOBject", nameof(data));
            }
            return await Task.Run(() => JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        internal static Task<string> Serialize(object gameResource)
        {
            throw new NotImplementedException();
        }
    }
}

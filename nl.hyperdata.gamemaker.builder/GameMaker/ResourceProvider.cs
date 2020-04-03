using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace nl.hyperdata.gamemaker.builder.GameMaker
{
    public class ResourceProvider
    {
        private string _path;
        private JObject _gameResource;

        public ResourceProvider(string path)
        {
            _path = path;
        }


        public void LoadFromFile()
        {
            _gameResource = Serializer.Deserialize(_path);
        }

        public void SaveChanges()
        {
            Serializer.Serialize(_path, _gameResource);
        }

        public void CreateExtension(string name)
        {
            JObject result = new JObject();
            result["Key"] = Guid.NewGuid().ToString();
            result["Value"] = new JObject();
            result["Value"]["resourcePath"] = $"extensions\\{name}\\{name}.yy";
            result["Value"]["resourceType"] = "GMExtension";
            result["Value"]["id"] = Guid.NewGuid().ToString();
            _gameResource["resources"].FirstOrDefault().AddAfterSelf(result);


            string p = $@"{Path.GetDirectoryName(_path)}\extensions\{name}\{name}.yy";

            Directory.CreateDirectory($@"{Path.GetDirectoryName(_path)}\extensions\{name}");

        }

        public JToken[] Resources
        {
            get
            {
                return _gameResource["resources"].ToArray();
            }
        }
    }
}

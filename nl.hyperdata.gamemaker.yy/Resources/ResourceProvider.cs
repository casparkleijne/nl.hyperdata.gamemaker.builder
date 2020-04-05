using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using nl.hyperdata.gamemaker.yy.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace nl.hyperdata.gamemaker.yy.Resources
{
    public class ResourceProvider
    {
        private string _path;
        private readonly ResourceFileHandler _handler;
        private JObject _gameResource;

        public ResourceProvider(string path)
        {
            _path = path;
            _handler = new ResourceFileHandler();
        }


        public async Task<JObject> GameResource()
        {            
            
            string json = await _handler.ReadFile(_path);
            
            try
            {
                _gameResource = JObject.Parse(json);
            }
            catch(Exception)
            {

            }
            return _gameResource;
        }

        public async Task<bool> SaveChanges()
        {
            string json = await Serializer.Serialize(_gameResource);
            return await _handler.WriteTextAsync(_path, json);
        }
    }
}

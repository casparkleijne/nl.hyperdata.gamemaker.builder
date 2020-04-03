using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nl.hyperdata.gamemaker.builder.GameMaker
{
    public static class ResourceExtensions
    {
        public static JToken[] AllExtensions(this JToken[] collection)
        {
            return collection.Where(x => x["Value"].Value<string>("resourceType").Equals("GMExtension"))
                .ToArray();
        }

        public static JToken FindByKey(this JToken[] collection, string key)
        {
            return collection.Where(x => x.Value<string>("Key").Equals(key))
                  .FirstOrDefault();
        }

        public static JToken FindExtension(this JToken[] collection, JToken item)
        {
            return collection.AllExtensions().FindByKey(item.Value<string>("Key"));
        }

        public static IEnumerable<string> AllExtensionNames(this JToken[] collection)
        {
            return collection.AllExtensions().Select(x => x["Value"].Value<string>("resourcePath")).ToArray();
        }
    }
}

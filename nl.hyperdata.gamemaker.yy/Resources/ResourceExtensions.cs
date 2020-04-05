using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nl.hyperdata.gamemaker.yy.Resources
{
    public static class ResourceExtensions
    {

        public static JToken[] Resources(this JObject item)
        {
            return item?["resources"]?.ToArray();
        }

        public static JToken[] Extensions(this JToken[] collection)
        {
            return collection?.Where(x => x["Value"].Value<string>("resourceType").Equals("GMExtension")).ToArray();
        }

        public static JToken FindByKey(this JToken[] collection, string key)
        {
            return collection?.Where(x => x.Value<string>("Key").Equals(key)).FirstOrDefault();
        }

        public static JToken FindExtension(this JToken[] collection, JToken item)
        {
            return collection?.FindByKey(item.Value<string>("Key"));
        }


    }
}

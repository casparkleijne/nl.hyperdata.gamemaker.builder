using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nl.hyperdata.gamemaker.builder.GameMaker
{
    public class ExtensionProvider
    {
        private string _path;

        public ExtensionProvider(string extensionPath, string ExtensionDllPath, string ExportDllPath)
        {
            var assembly1 = Assembly.ReflectionOnlyLoadFrom(ExtensionDllPath);
            var assembly2 = Assembly.ReflectionOnlyLoadFrom(ExportDllPath);

            _path = extensionPath;
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace nl.hyperdata.gamemaker.yy.Resources
{
    public class ResourceFileHandler : IDisposable
    {
        public async Task<string> ReadFile(string path)
        {
            if (File.Exists(path) == false)
            {
                return "";
            }

            string file;

            try
            {
                file = await ReadTextAsync(path);
            }
            catch (Exception)
            {
                return "";
            }

            return file;
        }

        private async Task<string> ReadTextAsync(string path)
        {
            using (FileStream sourceStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                
                int numRead;

                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.ASCII.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }

        public async Task<bool> WriteTextAsync(string path, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            using (FileStream sourceStream = new FileStream(path,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            };

            return true;

        }

        public void Dispose()
        {
         
        }
    }
}

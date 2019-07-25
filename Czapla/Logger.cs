using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Czapla
{
    public class Logger
    {
        private string fileName;
        private List<string> messages;
        private bool logging;

        public Logger(string fileName)
        {
            logging = false;
            messages = new List<string>();

            string nowdate = DateTime.Now.ToString("MM-dd-yyyy");
            this.fileName = $"logs/{fileName}_{nowdate}.log";
            if (!Directory.Exists("logs"))
                Directory.CreateDirectory("logs");
            if (!File.Exists(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)+ "/"+this.fileName))
                File.Create(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/" + this.fileName).Close();
        }

        public void AddMessage(string message)
        {
            while (logging) { }
                messages.Add(message);
        }

        public async Task Log()
        {
            logging = true;
            string nowdate = DateTime.Now.ToString("MM-dd-yyyy");
            var logWriter = new System.IO.StreamWriter(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/"+fileName, true);
            foreach (var item in messages)
            {
                await logWriter.WriteLineAsync($"[{DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")}] {item}");
            }
            messages.Clear();
            logWriter.Close();
            logWriter.Dispose();
            logging = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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
            this.fileName = $"{fileName}_{nowdate}.log";

            if (!File.Exists(this.fileName))
                File.Create(this.fileName).Close();
        }

        public void AddMessage(string message)
        {
            messages.Add(message);
        }

        public async Task Log()
        {
            logging = true;
            string nowdate = DateTime.Now.ToString("MM-dd-yyyy");
            var logWriter = new System.IO.StreamWriter(fileName, true);
            foreach (var item in messages)
            {
                await logWriter.WriteLineAsync($"[{DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")}] {item}");
            }
            logWriter.Close();
            logWriter.Dispose();
            logging = true;
        }
    }
}

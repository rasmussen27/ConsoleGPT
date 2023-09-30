using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleGPT
{
    public class Logger
    {
        public string filename { get; set; }

        public Logger(string theFilename)
        {
            filename = theFilename;

            string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            File.AppendAllText(filename, date + "|===================================================\n");

        }

        public void Log(string message)
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            message = date + "|" + message + Environment.NewLine;
            File.AppendAllText(filename, message);
        }

    }
}

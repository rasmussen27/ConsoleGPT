using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleGPT
{
    /// <summary>
    /// Loads / Creates config file
    /// </summary>
    public class Config
    {
        public Dictionary<string, string>? KeyValue { get; set; }

        public void LoadConfig()
        {
            //load a config file from local app data to a dictionary 
            string configfile = File.ReadAllText(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "/ConsoleGPT/settings.json");

            KeyValue = JsonConvert.DeserializeObject<Dictionary<string, string>>(configfile);
        }

        /// <summary>
        /// Create a blank config file if it doesn't already exist
        /// </summary>
        public void CreateBlankConfig()
        {
            string configDirectory = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "/ConsoleGPT";
            string configfile = "{\n\"ApiKeyOpenAI\":\"<<your key here>>\"\n}";

            //create directory for application and settings file if they don't exist
            if (!Directory.Exists(configDirectory))
            {
                Directory.CreateDirectory(configDirectory);

                if (!File.Exists(configDirectory + "/settings.json"))
                {
                    File.WriteAllText(configDirectory + "/settings.json", configfile);
                }
            }
        }

        public void CreateConfigYN()
        {

            //check if config file exists
            if (!File.Exists(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "/ConsoleGPT/settings.json"))
            {
                string answer = "";

                Console.WriteLine("Configuration file doesn't exists would you like one created? Y/N");
                Console.WriteLine("Config file will be located: " + Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "/ConsoleGPT/settings.json");

                answer = Console.ReadLine();

                if (answer.ToLower().Contains("y"))
                {
                    CreateBlankConfig();
                }

                Console.WriteLine("Exiting, Edit the config file with your OpenAI Api key");
                Environment.Exit(0);
            }
        }
    }
}

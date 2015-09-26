using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config;

            using (StreamReader file = File.OpenText(@"test.json"))
            {
                JsonSerializer ser = new JsonSerializer();
                config = (Config)ser.Deserialize(file, typeof(Config));
            }

            Console.WriteLine("server is " + config.settings.server);
            Console.ReadLine();

        }
    }
}

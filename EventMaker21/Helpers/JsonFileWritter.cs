using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using EventMaker21.Models;

namespace EventMaker21.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(List<Event> @events, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(@events, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

        public static void WriteToJsonCountry(List<Country> @events, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(@events, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}

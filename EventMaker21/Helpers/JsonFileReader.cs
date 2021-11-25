using EventMaker21.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace EventMaker21.Helpers
{
    public class JsonFileReader
    {
        public static List<Event> ReadJson(string jsonFileName)
        {
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<List<Event>>(jsonString);
        }

        public static List<Country> ReadJsonCountry(string jsonFileName)
        {
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<List<Country>>(jsonString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Helpers;
using EventMaker21.Interfaces;
using EventMaker21.Models;

namespace EventMaker21.Services
{
    public class JsonCountryRepository : ICountryRepository
    {
        string filePath = @"Data\JsonCountries.json";
        //string filePath =@"C:\Users\EASJ\OneDrive - Zealand Sjællands Erhvervsakademi(1)\Dokumenter\UV\SWC2020E\MineRazorProgrammer\RazorPagesEventMaker11frem\RazorPagesEventMaker\Data\JsonCountries.json";

        public List<Country> GetAllCountries()
        {
            return JsonFileReader.ReadJsonCountry(filePath);
        }

        public string GetCountryName(string code)
        {
            foreach (Country c in GetAllCountries())
            {
                if (c.Code == code)
                    return c.Name;
            }
            return "";
        }
        public Country GetCountry(string code)
        {
            foreach (Country c in GetAllCountries())
            {
                if (c.Code == code)
                    return c;
            }
            return new Country();
        }

        public void DeleteCountry(string code)
        {
            throw new NotImplementedException();
        }


        public void AddCountry(Country country)
        {
            List<Country> countries = GetAllCountries();
            countries.Add(country);
            JsonFileWritter.WriteToJsonCountry(countries, filePath);
        }

    }
}

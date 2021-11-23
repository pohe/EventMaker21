﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Interfaces;
using EventMaker21.Models;

namespace EventMaker21.Services
{
    public class FakeCountryRepository : ICountryRepository
    {
        private List<Country> countries { get; }
        public FakeCountryRepository()
        {
            countries = new List<Country>();
            countries.Add(new Country() { Code = "FR", Name = "France" });
            countries.Add(new Country() { Code = "DK", Name = "Denmark" });
            countries.Add(new Country() { Code = "SP", Name = "Spain" });
        }
        public List<Country> GetAllCountries()
        {
            return countries.ToList();
        }
        public Country GetCountry(string code)
        {
            foreach (var c in GetAllCountries())
            {
                if (c.Code == code)
                    return c;
            }
            return new Country();
        }

        public void DeleteCountry(string code)
        {
            if (code != null)
            {
                foreach (var country in GetAllCountries())
                {
                    if (country.Code == code)
                    {
                        countries.Remove(country);

                    }
                }

            }
        }


        public void AddCountry(Country country)
        {
            if (country != null)
            {
                countries.Add(country);
            }
        }
    }
}

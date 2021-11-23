using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Interfaces;
using EventMaker21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventMaker21.Pages.Countries
{
    public class CountryIndexModel : PageModel
    {
        public List<Country> Countries { get; private set; }

        public CountryIndexModel(ICountryRepository  repository)
        {
            Countries = repository.GetAllCountries();
        }

        public void OnGet()
        {
        }
    }
}

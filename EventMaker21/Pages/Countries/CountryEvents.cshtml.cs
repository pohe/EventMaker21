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
    public class CountryEventsModel : PageModel
    {
        private IEventRepository repo;

        public List<Event> Events { get; set; }

        public CountryEventsModel(IEventRepository repository)
        {
            repo = repository;
        }
        public void OnGet(string code)
        {
            Events = repo.SearchEventByCode(code);

        }
    }
}

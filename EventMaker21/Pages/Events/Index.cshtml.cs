using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Interfaces;
using EventMaker21.Models;
using EventMaker21.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventMaker21.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IEventRepository repo;

        public List<Event> Events { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public IndexModel(IEventRepository repository)
        {
            //repo = new FakeEventRepository();
            //repo= FakeEventRepository.Instance;
            repo = repository;
        }

        public void OnGet()
        {
            //Events = repo.GetAllEvents();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Events = repo.FilterEvents(FilterCriteria);
            }
            else
            {
                Events = repo.GetAllEvents();
            }
        }



        //public void OnPost()
        //{
        //    if (!string.IsNullOrEmpty(FilterCriteria))
        //    {
        //        Events = repo.FilterEvents(FilterCriteria);
        //    }
        //    else
        //    {
        //        Events = repo.GetAllEvents();
        //    }
        //}
    }
}

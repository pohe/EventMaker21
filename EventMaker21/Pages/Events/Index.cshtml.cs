using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventMaker21.Pages.Events
{
    public class IndexModel : PageModel
    {
        private FakeEventRepository repo;

        public List<Event> Events { get; private set; }

        public IndexModel()
        {
            //repo = new FakeEventRepository();
            repo= FakeEventRepository.Instance;
        }

        public void OnGet()
        {
            Events = repo.GetAllEvents();
        }
    }
}

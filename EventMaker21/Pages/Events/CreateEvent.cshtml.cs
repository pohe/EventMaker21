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
    public class CreateEventModel : PageModel
    {
        private IEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public CreateEventModel(IEventRepository repository)
        {
            //repo = new FakeEventRepository();
            //repo = FakeEventRepository.Instance;
            repo = repository;
        }

        public IActionResult OnGet()  //N�r der hentes
        {
            return Page();
        }

        public IActionResult OnPost() //N�r der opres eller �ndres i data
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            repo.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}

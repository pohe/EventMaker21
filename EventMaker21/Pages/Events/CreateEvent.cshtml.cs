using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventMaker21.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private FakeEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public CreateEventModel()
        {
            //repo = new FakeEventRepository();
            repo = FakeEventRepository.Instance;
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

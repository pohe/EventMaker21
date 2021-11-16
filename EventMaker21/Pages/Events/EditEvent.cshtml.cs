using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventMaker21.Pages.Events
{
    public class EditEventModel : PageModel
    {

        private FakeEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel()
        {
            repo = FakeEventRepository.Instance;
        }

        
        public IActionResult OnGet(int id)
        {
            Event = repo.GetEvent(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            repo.Update(Event);
            return RedirectToPage("index");
        }
    }
}

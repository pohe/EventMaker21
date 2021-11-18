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
    public class EditEventModel : PageModel
    {

        private IEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel(IEventRepository repository)
        {
            //repo = FakeEventRepository.Instance;
            repo = repository;
        }

        
        public IActionResult OnGet(int id)
        {
            Event = repo.GetEvent(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            repo.UpdateEvent(Event);
            return RedirectToPage("index");
        }
    }
}

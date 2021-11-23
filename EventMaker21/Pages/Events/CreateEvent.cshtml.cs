using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMaker21.Interfaces;
using EventMaker21.Models;
using EventMaker21.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventMaker21.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public SelectList CountryCodes { get; set; }


        public CreateEventModel(IEventRepository repository, ICountryRepository cRepo)
        {
            //repo = new FakeEventRepository();
            //repo = FakeEventRepository.Instance;
            repo = repository;
            List<Country> countries = cRepo.GetAllCountries();
            CountryCodes = new SelectList(countries, "Code", "Name");
        }

        public IActionResult OnGet()  //Når der hentes
        {
            return Page();
        }

        public IActionResult OnPost() //Når der opres eller ændres i data
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

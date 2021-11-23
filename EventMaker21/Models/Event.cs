using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventMaker21.Models
{
    public class Event
    {
        public int Id { get; set; }

        [DisplayName("Landekode")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "Name is required"), MaxLength(30)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "Max length is 18 chars for City")]
        public string City { get; set; }
        [Required(ErrorMessage = "The date is required")]
        [Range(typeof(DateTime),"10/1/2020", "10/1/2022", ErrorMessage = "Error on date range")]

        public DateTime DateTime { get; set; }
    }
}

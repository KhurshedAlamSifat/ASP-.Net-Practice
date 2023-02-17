using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Models
{
    public class RegSubmit
    {
        [Required(ErrorMessage = "Please provide your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide your ID")]
        [MinLength(5, ErrorMessage = "ID not less than 5 character")]
        public string Id { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public RegSubmit()
        {
            Dob = DateTime.Now;
        }
    }
}
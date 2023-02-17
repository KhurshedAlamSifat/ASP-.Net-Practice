using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormSubmit.Models
{
    public class RegSubmit
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string Gender { get; set; }

        public string Profession { get; set; }

        public string[] Hobbies { get; set; }

        public DateTime Dob { get; set; }
    }
}
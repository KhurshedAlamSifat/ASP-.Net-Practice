using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MidAssignment.EF.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Gender { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public string Password { get; set; }
        [ForeignKey("Restaurant")]

        public virtual ICollection<Restaurant> Restaurants { get; set;}

        public Employee()
        {
            Restaurants= new List<Restaurant>();
        }

    }
}
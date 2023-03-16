using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MidAssignment.EF.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [ForeignKey("Employee")]
        public virtual ICollection<Employee> Employees { get; set;}

        public Restaurant()
        {
            Employees = new List<Employee>();
        }

    }
}
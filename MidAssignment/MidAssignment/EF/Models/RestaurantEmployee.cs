using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MidAssignment.EF.Models
{
    public class RestaurantEmployee
    {
        [Key]
        public int Id{ get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId{ get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
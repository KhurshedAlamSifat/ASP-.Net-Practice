using MidAssignment.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MidAssignment.EF
{
    public class NGO : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Employee> Employees { get; set;}
        public DbSet<RestaurantEmployee> RestaurantEmployees { get; set;}
    }
}
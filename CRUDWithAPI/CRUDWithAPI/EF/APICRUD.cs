using CRUDWithAPI.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDWithAPI.EF
{
    public class APICRUD : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
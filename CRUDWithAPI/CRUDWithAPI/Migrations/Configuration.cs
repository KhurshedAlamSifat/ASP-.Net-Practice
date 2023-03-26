namespace CRUDWithAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUDWithAPI.EF.APICRUD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUDWithAPI.EF.APICRUD context)
        {
            context.Employees.AddOrUpdate(
                c => c.Id,
                new EF.Models.Employee { Name = "Sifat", Salary = 40000 },
                new EF.Models.Employee { Name = "Mugdho", Salary = 20500 },
                new EF.Models.Employee { Name = "Ahsan", Salary = 32000 },
                new EF.Models.Employee { Name = "Mahfuz", Salary = 25000 }
                );
        }
    }
}

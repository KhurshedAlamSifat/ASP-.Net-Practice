using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        static EmpContext db;

        static EmployeeRepo()
        {
            db = new EmpContext();
        }
        public static List<Employee> Get()
        {
           return db.Employees.ToList();
          /* List<Employee> list = new List<Employee>();
            for(int i=1; i<=10; i++)
            {
                list.Add(new Employee() { Id = i, Name = "Employee-" + i, Age = 30 }) ;
            }
            return list;*/
        }
        public static Employee Get(int id)
        {
            return db.Employees.Find(id);
        }
        public static bool Create(Employee employee)
        {
            db.Employees.Add(employee);
            return db.SaveChanges() > 0;
        }
        public static bool Update(Employee employee)
        {
            var ExEmployee = Get(employee.Id);
            db.Entry(ExEmployee).CurrentValues.SetValues(employee);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            var ExEmployee = Get(id);
            db.Employees.Remove(ExEmployee);
            return db.SaveChanges() > 0;
        }
    }
}

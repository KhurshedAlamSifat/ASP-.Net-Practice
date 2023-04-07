using BLL.DTOs;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sevices
{
    public class EmployeeService
    {
        public static List<EmployeeDTO> Get()
        {
            var data = EmployeeRepo.Get();
            return Convert(data);
        }
        public static EmployeeDTO Get(int id)
        {
            return Convert(EmployeeRepo.Get(id));
        }
        public static bool Create(EmployeeDTO employee)
        {
            return EmployeeRepo.Create(Convert(employee));
        }
        public static bool Update(EmployeeDTO employee)
        {
            return EmployeeRepo.Update(Convert(employee));
        }
        public static bool Delete(int id)
        {
            return EmployeeRepo.Delete(id);
        }

        static EmployeeDTO Convert(Employee employee)
        {
            return new EmployeeDTO()
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age
            };
        }
        static Employee Convert(EmployeeDTO employee)
        {
            return new Employee()
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age
            };
        }
        static List<EmployeeDTO> Convert(List<Employee> employees) 
        {
            var data = new List<EmployeeDTO>();
            foreach(var employee in employees)
            {
                data.Add(Convert(employee));
            }
            return data;
        }
    }
}

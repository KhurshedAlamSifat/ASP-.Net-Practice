using API_DataPassing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_DataPassing.Controllers
{
    public class DataPassController : ApiController
    {
        [HttpGet]
        [Route("api/students/all")]
        public List<Student> AllStudents()
        {
            var students = new List<Student>();
            for (int i = 1; i <= 5; i++)
            {
                students.Add(new Student()
                {
                    Id = i,
                    Name = "Student " + i,
                    Dept = "CSE"
                });
            }
            return students;
        }

        [HttpGet]
        [Route("api/students/names")]
        public List<string> StudentsName()
        {
            var students = new List<Student>();
            for (int i = 1; i <= 5; i++)
            {
                students.Add(new Student()
                {
                    Id = i,
                    Name = "Student " + i,
                    Dept = "CSE"
                });
            }
            var names = (from s in students
                         select s.Name).ToList();
            return names;
        }

        [HttpGet]
        [Route("api/manual/names")]
        public List<string> GetStudents()
        {
            string[] names = new string[] { "Sifat", "Shafi", "Nadim", "Tanim", "Mugdho", "Ahsan" };
            return names.ToList();
        }
    }
}

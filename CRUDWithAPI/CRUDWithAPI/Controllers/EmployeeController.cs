using CRUDWithAPI.EF;
using CRUDWithAPI.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDWithAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public HttpResponseMessage Allemployee()
        {
            APICRUD db = new APICRUD();
            var data = db.Employees.ToList();
            if (data.Count > 0 )
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        [HttpGet]
        [Route("api/employees/{id}")]
        public HttpResponseMessage FindEmployees( int id) 
        {
            APICRUD db = new APICRUD();
            var data = db.Employees.Find(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No employee founded");
        }

        [HttpPost]
        [Route("api/employees/add")]
        public HttpResponseMessage AddEmployee(Employee employee)
        {
            APICRUD db = new APICRUD();
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "New Employee Added Successfully!");
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
    }
}

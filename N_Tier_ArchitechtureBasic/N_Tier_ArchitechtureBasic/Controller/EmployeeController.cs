using BLL.DTOs;
using BLL.Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N_Tier_ArchitechtureBasic.Controller
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public HttpResponseMessage AllEmployees()
        {
            try
            {
                var data = EmployeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/employees/add")]
        public HttpResponseMessage Add(EmployeeDTO data)
        {
            try
            {
                var res = EmployeeService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex.Message);
            }
        }
    }
}

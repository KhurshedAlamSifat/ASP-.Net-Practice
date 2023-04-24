using BLL.Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FullStack.Controllers
{
    public class PostController : ApiController
    {
        [HttpGet]
        [Route("api/posts")]
        public HttpResponseMessage Posts()
        {
            try
            {
                var data = PostService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new{Massage=ex.Message});
            }
        }
    }
}

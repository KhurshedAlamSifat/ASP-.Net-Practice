using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalTermTask1.Controller
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/news")]
        public HttpResponseMessage AllNews()
        {
            try
            {
                var data = NewsService.Getall();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/news/add")]
        public HttpResponseMessage AddNews(NewsDTO news)
        {
            try
            {
                var data = NewsService.Insert(news);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/news/update")]
        public HttpResponseMessage UpdateNews(NewsDTO news)
        {
            {
                try
                {
                    var data = NewsService.Update(news);
                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

        }
    }
}

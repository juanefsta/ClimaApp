using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HxClima.Controllers
{
    public class DiaController : ApiController
    {
         [HttpGet]
        public IHttpActionResult Dias()
        {
            //var json = JsonConvert.DeserializeObject();
            return Ok(200);
        }
    }
}


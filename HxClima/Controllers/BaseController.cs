using HxClimaWebApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HxClima.Controllers
{
    public class BaseController : ApiController
    {

        List<DailyForecast> dias;
        public IHttpActionResult GetFiveDays()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://dataservice.accuweather.com/forecasts/v1/daily/5day/7894?4eq974m8yEZNwRONLMCGs9Kzx9MkUOwV&apikey=4eq974m8yEZNwRONLMCGs9Kzx9MkUOwV&language=es-ar&details=false&metric=true");
                dias = JsonConvert.DeserializeObject<RootObject>(json).DailyForecasts;
            }

            return Ok(dias);
        }
        
        public IHttpActionResult DiasQueRealizaActividad(string s)
        {
            var json = JsonConvert.DeserializeObject(s);
            return null;
        }
    }
}

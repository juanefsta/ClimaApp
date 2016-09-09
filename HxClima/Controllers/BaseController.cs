using HxClima.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            List<Clima> climas = new List<Clima>();
            /* Creo un foreach que me devuelve la informacion necesaria del clima para cada dia
             * fecha, temperaturas y el icono (que está asociado a un estado del tiempo)
             * */
            foreach(var dia in dias)
                {
                    Clima nuevoClima = new Clima(dia.Date, dia.Temperature.Minimum.Value,
                                                 dia.Day.Icon,
                                                 dia.Night.Icon);
                    climas.Add(nuevoClima);
                    continue;
                }

            return Ok(climas);
        }
    }
}

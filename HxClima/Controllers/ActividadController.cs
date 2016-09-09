using HxClima.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HxClima.Controllers
{
    public class ActividadController : ApiController
    {
        Actividad[] actividades = new Actividad[]
        {
            new Actividad {ActividadID = 1, Nombre ="Futbol", TempMax=28, TempMin=14, LluviaIndispensable = false},
            new Actividad {ActividadID = 2, Nombre ="Natacion", TempMax=30, TempMin=12, LluviaIndispensable = false},
            new Actividad {ActividadID = 3, Nombre ="Running", TempMax=29, TempMin=13, LluviaIndispensable = false}
        };

        public IEnumerable<Actividad> GetAllActividades()
        {
            return actividades;
        }

        public IHttpActionResult GetActividad(int id)
        {
            var actividad = actividades.FirstOrDefault((p) => p.ActividadID == id);
            if (actividad == null)
            {
                return NotFound();
            }
            return Ok(actividad);
        }
    }
}

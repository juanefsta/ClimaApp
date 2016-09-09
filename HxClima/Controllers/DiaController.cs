using HxClima.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace HxClima.Controllers
{
    public class DiaController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Dias(JObject json)
        {
            Json recibo = JsonConvert.DeserializeObject<Json>(json.ToString());
            Actividad actividad = JsonConvert.DeserializeObject<Actividad>(recibo.actividad.ToString());
            int diasPosibles = 0;
            int[] estadoDelClima = new int[] { 2 };
            int indexOfArray = 0;
            while (diasPosibles < recibo.dia || indexOfArray < recibo.climas.Length)
            {
                bool hayLluvias = false;
                bool superaTempMin = false;

                //Pregunto si el estado coincide con alguno lluvioso
                if (incluye(estadoDelClima, recibo.climas[indexOfArray].iDia) ||
                    incluye(estadoDelClima, recibo.climas[indexOfArray].iNoche))
                {
                    hayLluvias = true;
                }
                //Pregunto si la temperatura minima es menor a la esperada
                if (recibo.climas[indexOfArray].tempMinima < actividad.TempMin)
                {
                    superaTempMin = true;
                }

                if (actividad.LluviaIndispensable.Equals(hayLluvias) ||
                    !superaTempMin)
                {
                    diasPosibles++;
                }
                indexOfArray++;
            }

            return Ok(diasPosibles);
        }

        private bool incluye(int[] estados, int icon)
        {
            /* 
             * DEVUELVE TRUE si la frase y un estado coinciden
             * 
             * UTILIZADO PARA AVERIGUAR SI UN DEPORTE PUEDE REALIZARSE
             * DEPENDIENDO EL ESTADO DEL CLIMA
             * 
             */
            bool encuentra = false;
            int index = 0;
            while (!encuentra)
            {
                if (estados[index].Equals(icon))
                {
                    encuentra = true;
                }
                else
                {
                    index++;
                }
            }
            return encuentra;
        }

    }
}


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
            int[] estadoDelClima = new int[] { 8, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 29, 39, 40, 41, 42, 43, 44 };
            int indexOfList = 0;
            List<dynamic> devuelve = new List<dynamic>();
            while (diasPosibles < recibo.dia && indexOfList < recibo.climas.Count)
            {
                dynamic dia = new JObject();
                bool hayLluvias = false;
                bool superaTempMin = false;

                //Pregunto si el estado coincide con alguno lluvioso siempre y cuando influya el mal tiempo
                if (actividad.LluviaIndispensable)
                {
                    if (incluye(estadoDelClima, recibo.climas.ElementAt(indexOfList).iDia) ||
                        incluye(estadoDelClima, recibo.climas.ElementAt(indexOfList).iNoche))
                    {
                        hayLluvias = true;
                    }
                }

                //Pregunto si la temperatura minima es menor a la esperada
                if (recibo.climas.ElementAt(indexOfList).tempMinima < actividad.TempMin)
                {
                    superaTempMin = true;
                }

                if (actividad.LluviaIndispensable.Equals(hayLluvias) &&
                    !superaTempMin)
                {
                    diasPosibles++;
                    dia.fecha = recibo.climas.ElementAt(indexOfList).date;
                    dia.sePuede = true;
                    dia.explicacion = "";
                    devuelve.Add(dia);
                }
                else
                {
                    dia.fecha = recibo.climas.ElementAt(indexOfList).date;
                    dia.sePuede = false;
                    dia.explicacion ="mal tiempo";
                    devuelve.Add(dia);
                }
                indexOfList++;
            }

            return Ok(devuelve);
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
            for (int i = 0; i < estados.Length; i++)
            {
                if (estados[i].Equals(icon))
                {
                    encuentra = true;
                    break;
                }
            }
            return encuentra;
        }

    }
}


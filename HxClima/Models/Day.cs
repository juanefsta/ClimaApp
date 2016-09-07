using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClimaWebApp.Models
{
    public class Day
    {
        [JsonProperty("Icon")]
        public int Icon { get; set; }

        [JsonProperty("IconPhrase")]
        public string IconPhrase { get; set; }
    }

}
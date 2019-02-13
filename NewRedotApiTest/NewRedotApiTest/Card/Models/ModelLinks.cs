﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRedotApiTest.Card.Models
{
    public class ModelLinks
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }
    }
}

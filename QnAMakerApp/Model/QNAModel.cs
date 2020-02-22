using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QnAMakerApp.Model
{
    public class QNAModel
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("questions")]
        public List<string> Questions { get; set; }

    }
}

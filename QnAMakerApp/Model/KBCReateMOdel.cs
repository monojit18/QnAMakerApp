using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace QnAMakerApp.Model
{
    public class KBCReateModel
    {

        [JsonProperty("name")]
        public string Name { get; set; }             

        [JsonProperty("questions")]
        public List<QNAModel> QNAList { get; set; }
        
    }
}

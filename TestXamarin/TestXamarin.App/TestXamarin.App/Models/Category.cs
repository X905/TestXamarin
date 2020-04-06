using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TestXamarin.App.Models
{
    public class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nameCategory")]
        public string NameCategory { get; set; }
        public Color ButtonBackGroundColor { get; set; }
    }
}

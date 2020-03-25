

namespace TestXamarin.App.Models
{
    using Newtonsoft.Json;
    using System;
    public class Product
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nameProduct")]
        public string NameProduct { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("imageFullPath")]
        public Uri ImageFullPath { get; set; }
    }
}

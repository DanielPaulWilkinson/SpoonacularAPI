using Newtonsoft.Json;
using System;

namespace Fooch
{
    [Serializable]
    public class Recipe
    {
        [JsonProperty("id")]
        public int Id { get; set;}

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }
    }
}

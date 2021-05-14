using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooch
{
    [Serializable]
    public class RecipeList
    {
        [JsonProperty("results")]
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}

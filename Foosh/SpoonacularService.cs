using Fooch;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class SpoonacularService : ISpoonacularService
{
	public async Task<IEnumerable<Recipe>> Get5Recipies(String query)
    {
        List<Recipe> recipes = new List<Recipe>();

        var url = $"https://api.spoonacular.com/recipes/complexSearch";
        var parameters = $"?query={query}&apiKey={Consts.SpoonacularKey}&number=5";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage response = await client.GetAsync(parameters).ConfigureAwait(false);  
       
        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var recipeList = JsonConvert.DeserializeObject<RecipeList>(jsonString);

            if (recipeList != null)
            {
                recipes.AddRange(recipeList.Recipes);
            }
        }
        
        return recipes;
    }
}

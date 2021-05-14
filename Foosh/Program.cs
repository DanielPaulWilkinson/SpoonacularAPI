using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;

namespace Fooch
{
    class Program
    {

        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            Application application = new Application(services);
            var _spoonacular = application.Services.GetRequiredService<ISpoonacularService>();

            var recipes = _spoonacular.Get5Recipies("pizza").GetAwaiter().GetResult();
           
            foreach(Recipe recipe in recipes)
            {
                Console.WriteLine(recipe.Title);
            }

            Console.ReadKey();
        }
    }
}

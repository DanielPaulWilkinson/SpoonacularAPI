using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooch
{
    interface ISpoonacularService
    {
        Task<IEnumerable<Recipe>> Get5Recipies(String query);
    }
}

using HomeCooking.Data;
using HomeCooking.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HomeCooking.Repository
{
    public class RecipeRepository : HCRepository<Recipe>
    {
        private HCContext _dbContext = null;
        public RecipeRepository(HCContext dbContext) : base(dbContext.Recipes)
        {
            _dbContext = dbContext;
        }
    }
}

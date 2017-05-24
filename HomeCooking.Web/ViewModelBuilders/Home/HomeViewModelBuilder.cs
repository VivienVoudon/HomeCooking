using HomeCooking.Core;
using HomeCooking.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCooking.Web.ViewModelBuilders.Home
{
    public class HomeViewModelBuilder
    {
    
        public HomeViewModel Build()
        {
            AccountServices accountServices = new AccountServices();
            var recipes = accountServices.GetRecipes();

            return new HomeViewModel
            {
                Recipes = recipes.Select(r => new HomeViewModel_Recipe
                {
                    CreatorName = r.RecipeCreator,
                    Name = r.RecipeName
                }).ToList(),
                Users = new List<string>()
            };
        }

    }
    
}
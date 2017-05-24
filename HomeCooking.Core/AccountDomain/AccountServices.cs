using HomeCooking.Data;
using HomeCooking.Poco;
using HomeCooking.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCooking.Core
{
    public class RecipeDto
    {
        public string RecipeName { get; set; }
        public string RecipeCreator { get; set; }
    }

    public class AccountServices
    {
        HomeCooking.Repository.UnitOfWork _uow;

        public AccountServices()
        {
            _uow = new HomeCooking.Repository.UnitOfWork();
        }
        
        public List<RecipeDto> GetRecipes()
        {
           var recipes = _uow.Repository<Recipe>().Query().Include(r => r.Creator).Select();

            return recipes.Select(r => new RecipeDto
            {
                RecipeCreator = r.Creator.NickName,
                RecipeName = r.Name
            }).ToList();
        }

        public void Test()
        {
            User user = new User()
            {
                Email = "vvoudon@gmail.com",
                NickName = "Vivasse",
                Password = "password",

            };

            Recipe recipe = new Recipe
            {
                Name = "couscous",
                Duration = 80,
            };

            user.Recipes.Add(recipe);

            _uow.Repository<User>().Insert(user);
            _uow.Repository<Recipe>().Insert(recipe);

            _uow.SaveChanges();
        }
    }
}

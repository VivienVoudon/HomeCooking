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
    public class AccountServices
    {
        HcUnitOfWork _uow;

        public AccountServices()
        {
            _uow = new HcUnitOfWork();
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

            _uow.UserRepository.Add(user);
            _uow.RecipeRepository.Add(recipe);

            _uow.SaveChanges();
        }

        //public void Test()
        //{
        //    using (var ctx = new HCContext())
        //    {
        //        User user = new User()
        //        {
        //            Email = "vvoudon@gmail.com",
        //            NickName = "Vivasse",
        //            Password = "password",

        //        };

        //        Recipe recipe = new Recipe
        //        {
        //            Name = "couscous",
        //            Duration = 80,
        //        };

        //        user.Recipes.Add(recipe);

        //        ctx.Recipes.Add(recipe);
        //        ctx.Users.Add(user);
        //        ctx.SaveChanges();
        //    }
        //}
    }
}

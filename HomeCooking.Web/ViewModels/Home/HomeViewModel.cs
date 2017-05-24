using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCooking.Web.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<HomeViewModel_Recipe> Recipes { get; set; }
        public List<string> Users { get; set; }
    }

    public class HomeViewModel_Recipe
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
    }
}
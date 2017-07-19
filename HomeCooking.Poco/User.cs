using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCooking.Poco
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }

        public ICollection<Recipe> Recipes { get; set; }

        public User()
        {
            this.Recipes = new HashSet<Recipe>();
        }
    }
}

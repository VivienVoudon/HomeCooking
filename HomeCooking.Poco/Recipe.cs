using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCooking.Poco
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        
        public User Creator { get; set; }
    }
}

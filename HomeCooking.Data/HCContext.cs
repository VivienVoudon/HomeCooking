using HomeCooking.Poco;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCooking.Data
{
    public class HCContext: DbContext
    {
        public HCContext():base("name=HCConnectionString")
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<Recipe> recipeConf = modelBuilder.Entity<Recipe>();
            recipeConf.ToTable("recipes");
            recipeConf.HasRequired<User>(o => o.Creator).WithMany(o => o.Recipes);

            EntityTypeConfiguration<User> userConf = modelBuilder.Entity<User>();
            userConf.ToTable("users");

            base.OnModelCreating(modelBuilder);
        }
    }
}

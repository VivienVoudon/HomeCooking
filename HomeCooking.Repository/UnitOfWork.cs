using HomeCooking.Data;
using HomeCooking.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCooking.Repository
{
    public class HcUnitOfWork : IDisposable
    {
        private HCContext _dbContext = null;
        public HcUnitOfWork()
        {
            _dbContext = new HCContext();
        }

        // Add all the repository handles here
        UserRepository contactRepository = null;
        RecipeRepository recipeRepository = null;

        // Add all the repository getters here
        public UserRepository UserRepository
        {
            get
            {
                if (contactRepository == null)
                {
                    contactRepository = new UserRepository(_dbContext);
                }

                return contactRepository;
            }
        }
        public RecipeRepository RecipeRepository
        {
            get
            {
                if (recipeRepository == null)
                {
                    recipeRepository = new RecipeRepository(_dbContext);
                }

                return recipeRepository;
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

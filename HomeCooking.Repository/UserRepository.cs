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
    public class UserRepository : HCRepository<User>
    {
        private HCContext _dbContext = null;
        public UserRepository(HCContext dbContext) : base(dbContext.Users)
        {
            _dbContext = dbContext;
        }
    }
}

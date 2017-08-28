using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestPay.Repository
{
    public class UserRepository
    {
        public FestPayEntities EntityContext { get; private set; }

        public UserRepository(FestPayEntities entityContext)
        {
            EntityContext = entityContext;
        }

        public User GetUserById(int userId)
        {
            var user = EntityContext.Users.FirstOrDefault(u => u.Id == userId);
            return user;
        }

        public User Add(User user)
        {
            EntityContext.Users.Add(user);
            EntityContext.SaveChanges();

            var newUser = EntityContext.Users.Last();
            return newUser;
        }

        public User Modify(User user)
        {
            var trackedUser = EntityContext.Users.FirstOrDefault(u => u.Id == user.Id);

            trackedUser.Email = user.Email;
            
            //for entity framework settings that have untracked changes
            //EntityContext.Entry(trackedUser).State = System.Data.Entity.EntityState.Modified;

            EntityContext.SaveChanges();

            return trackedUser;
        }
    }
}

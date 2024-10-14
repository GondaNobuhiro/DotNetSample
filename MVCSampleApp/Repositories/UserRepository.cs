using MVCSampleApp.Data;
using MVCSampleApp.Models.Entity;

namespace MVCSampleApp.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly MVCSampleAppContext _mVCSampleAppContext;

        public UserRepository(MVCSampleAppContext mVCSampleAppContext) { 
            _mVCSampleAppContext = mVCSampleAppContext;
        }

        public void addUser(User user)
        {
            _mVCSampleAppContext.User.Add(user);
            _mVCSampleAppContext.SaveChanges();
        }

    }
}

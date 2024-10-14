using MVCSampleApp.Models.Entity;
using MVCSampleApp.Repositories;

namespace MVCSampleApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) { 
            _userRepository = userRepository;
        }

        public void addUser(User user)
        {
            _userRepository.addUser(user);
        }
    }
}

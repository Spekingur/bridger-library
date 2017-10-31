using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
        
        public UserDetailsDTO AddNewUser(UserViewModel newUser)
        {
            var user = _repo.AddNewUser(newUser);
            return user;
        }

        public IEnumerable<UserDTO> GetAllActiveUsers()
        {
            var users = _repo.GetAllActiveUsers();
            return users;
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            var users = _repo.GetAllUsers();
            return users;
        }

        public UserDetailsDTO GetUserById(int userId)
        {
            var user = _repo.GetUserById(userId);
            return user;
        }

        public bool RemoveUser(int userId)
        {
            return _repo.RemoveUser(userId);
        }

        public UserDetailsDTO UpdateUserInfo(int userId, UserViewModel updatedUser)
        {
            var user = _repo.UpdateUserInfo(userId, updatedUser);
            return user;
        }
    }
}
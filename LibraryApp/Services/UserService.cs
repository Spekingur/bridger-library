using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Services
{
    public class UserService : IUserService
    {
        public UserDetailsDTO AddNewUser(UserViewModel newUser)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public UserDetailsDTO GetUserById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public UserDetailsDTO UpdateUserInfo(int userId, UserViewModel updateUser)
        {
            throw new System.NotImplementedException();
        }
    }
}
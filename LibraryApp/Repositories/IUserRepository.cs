using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    /// <summary>
    /// Interface for database functions for user repo
    /// </summary>
    public interface IUserRepository
    {
        UserDetailsDTO AddNewUser(UserViewModel newUser);

        UserDetailsDTO UpdateUserInfo(int userId, UserViewModel updatedUser);

        bool RemoveUser(int userId);

        bool AdminRemoveUserFromDatabase(int userId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        UserDetailsDTO GetUserById(int userId);

        /// <summary>
        /// Fetching all users whether they are active or not
        /// </summary>
        /// <returns>Returns both active and "deleted" users</returns>
        IEnumerable<UserDTO> GetAllUsers();

        IEnumerable<UserDTO> GetAllActiveUsers();
    }
}
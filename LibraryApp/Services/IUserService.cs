using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using System.Collections.Generic;

namespace LibraryApp.Services
{
    /// <summary>
    /// Interface for user service
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Fetches a list of all users
        /// </summary>
        /// <returns>A list of users</returns>
        IEnumerable<UserDTO> GetAllUsers();

        /// <summary>
        /// Fetches one instance of user with the given userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Details about a user</returns>
        UserDetailsDTO GetUserById(int userId);

        /// <summary>
        /// Adds a new user to the database
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns>The user details in the database</returns>
        UserDetailsDTO AddNewUser(UserViewModel newUser);

        /// <summary>
        /// Updates user info in the database
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="updateUser"></param>
        /// <returns>The updated user info from database</returns>
        UserDetailsDTO UpdateUserInfo(int userId, UserViewModel updatedUser);

        /// <summary>
        /// Removes user from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>True if user was successfully removed, else false</returns>
        bool RemoveUser(int userId);

        IEnumerable<UserDTO> GetAllActiveUsers();
    }
}
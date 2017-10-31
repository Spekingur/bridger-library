using System;

namespace LibraryApp.Models.EntityModels
{
    /// <summary>
    /// Entity model for a user. Direct mapping to the database.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id of the user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Full name of the user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Home address of the user
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Telephone number of the user
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Marks whether or not the user is active or disabled in the system
        /// (rather than fully delete)
        /// </summary>
        /// <returns></returns>
        public bool Active { get; set; }
        /// <summary>
        /// Date of when the user was registered
        /// </summary>
        public DateTime RegisterDate { get; set; }

        public int Usergroup { get; set; }
    }
}
using System;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// Model for admin of user
    /// </summary>
    public class UserAdminDTO
    {
        /// <summary>
        /// Id of user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Address of user
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Email of user
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Telephone number of user
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Date the user was registered in the system
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// Set to false if the user is "deleted"
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// The usergroup the user is in
        /// </summary>
        public string Usergroup { get; set; }
    }
}
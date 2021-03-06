namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A simple model of a user
    /// </summary>
    public class UserDTO
    {
        /// <summary>
        /// ID of user
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
        /// The usergroup the user belongs to
        /// </summary>
        public int Usergroup { get; set; }
    }
}
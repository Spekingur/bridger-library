using System;
using System.Collections.Generic;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A detailed model of a user.
    /// </summary>
    public class UserDetailsDTO
    {
        public UserDetailsDTO() {
            Outloans = new List<OutloanListBooksDTO>();
            Reviews = new List<ReviewListBooksDTO>();
        }
        /// <summary>
        /// Id of the user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Address of the user
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
        /// Date of when the user registered
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// List of loan history of the user
        /// </summary>
        public IEnumerable<OutloanListBooksDTO> Outloans { get; set; }
        /// <summary>
        /// List of reviews the user has written
        /// </summary>
        public IEnumerable<ReviewListBooksDTO> Reviews { get; set; }
    }
}
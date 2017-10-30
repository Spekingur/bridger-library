using System;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A simple model for listing loan history of users for a specific book.
    /// </summary>
    public class OutloanListUsersDTO
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date of the outloan
        /// </summary>
        public DateTime LoanDate { get; set; }
        /// <summary>
        /// Date of the return of book
        /// </summary>
        public DateTime? ReturnDate { get; set; }
    }
}
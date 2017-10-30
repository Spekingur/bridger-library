using System;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A simple model for listing loan history of books under a certain user.
    /// </summary>
    public class OutloanListBooksDTO
    {
        /// <summary>
        /// Title of a book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Date of loan
        /// </summary>
        public DateTime LoanDate { get; set; }
        /// <summary>
        /// Date of return, if returned
        /// </summary>
        public DateTime? ReturnDate { get; set; }
        
    }
}
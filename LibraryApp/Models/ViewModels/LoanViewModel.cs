using System;

namespace LibraryApp.Models.ViewModels
{
    /// <summary>
    /// View model for a loan
    /// </summary>
    public class LoanViewModel
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        /// <summary>
        /// Date of outloan of book
        /// </summary>
        public DateTime LoanDate { get; set; }
        /// <summary>
        /// Date of return book
        /// </summary>
        public DateTime? ReturnDate { get; set; }
        /// <summary>
        /// Whether book has been returned or not
        /// </summary>
        public bool Returned { get; set; }
    }
}
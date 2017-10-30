using System;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A detailed information about an outloan exposed to users.
    /// </summary>
    public class OutloanDetailsDTO
    {
        /// <summary>
        /// Name of the user that got the book
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of the book that is loaned
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Date of when the book was loaned out
        /// </summary>
        public DateTime LoanDate { get; set; }
        /// <summary>
        /// Date of when the book was returned
        /// (if it has been returned yet)
        /// </summary>
        public DateTime? ReturnDate { get; set; }
        /// <summary>
        /// A simple boolean value to tell if the book has
        /// been returned or not
        /// </summary>
        public bool Returned { get; set; }
    }
}
using System;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A simple model of an outloan visible to users.
    /// </summary>
    public class OutloanDTO
    {
        /// <summary>
        /// Name of the user that has the book
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Title of the book that is loaned
        /// </summary>
        public string BookTitle { get; set; }
        /// <summary>
        /// Date of the loan
        /// </summary>
        public DateTime LoanDate { get; set; }
    }
}
using System;

namespace LibraryApp.Models.EntityModels
{
    /// <summary>
    /// Entity model for a loan of a book. Direct mapping to database.
    /// </summary>
    public class Outloan
    {
        /// <summary>
        /// Id of the loan
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id of the book involved in the loan
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// Id of the user involved in the loan
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// The date of when the book was loaned out
        /// </summary>
        public DateTime LoanDate { get; set; }
        /// <summary>
        /// The date of when the book was returned
        /// </summary>
        public DateTime ReturnDate { get; set; }
        /// <summary>
        /// Fast way to keep track of whether a book has been returned or not
        /// </summary>
        public bool Returned { get; set; }
    }
}
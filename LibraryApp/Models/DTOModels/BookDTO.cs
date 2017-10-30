using System;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A medium detailed model for a book.
    /// </summary>
    public class BookDTO
    {
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Full name of the author of the book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The date of release of book
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// ISBN number of book
        /// </summary>
        public string Isbn { get; set; }
    }
}
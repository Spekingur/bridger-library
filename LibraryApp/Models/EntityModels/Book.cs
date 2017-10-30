using System;

namespace LibraryApp.Models.EntityModels
{
    /// <summary>
    /// Entity model for a book. Direct mapping to database.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Id of the book
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Full name of the author of the book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The date of when the book was released
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// The ISBN number of the book
        /// </summary>
        public string Isbn { get; set; }
        /// <summary>
        /// The date of when the book was added to the library database
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
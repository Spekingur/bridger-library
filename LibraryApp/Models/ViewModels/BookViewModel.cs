using System;

namespace LibraryApp.Models.ViewModels
{
    /// <summary>
    /// View model of a book
    /// </summary>
    public class BookViewModel
    {
        /// <summary>
        /// Title of a book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Name of the author of book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Date of the release of book
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// ISBN number of book
        /// </summary>
        public string Isbn { get; set; }
    }
}
namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A small rating model exposed to users. For use in lists when viewing a book.
    /// </summary>
    public class ReviewListUsersDTO
    {
        /// <summary>
        /// Name of the user that made review
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The rating the user gave the book
        /// </summary>
        public int Rating { get; set; }
    }
}
namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A very lite model of a book. Best used in lists.
    /// </summary>
    public class BookLiteDTO
    {
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Name of the author of book
        /// </summary>
        public string Author { get; set; }
    }
}
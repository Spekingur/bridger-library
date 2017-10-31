namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A very lite model of a book. Best used in lists.
    /// </summary>
    public class BookLiteDTO
    {
        /// <summary>
        /// ID of the book
        /// </summary>
        public int Id { get; set; }
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
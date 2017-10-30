namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A simple model for use in lists when viewing a user.
    /// </summary>
    public class ReviewListBooksDTO
    {
        /// <summary>
        /// Title of the rated book
        /// </summary>
        public string Title { get; set; }        
        /// <summary>
        /// The rating of the book
        /// </summary>
        public string Rating { get; set; }
    }
}
namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A simple model for use in lists when viewing a user.
    /// </summary>
    public class ReviewListBooksDTO
    {
        /// <summary>
        /// Id of the review
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of the rated book
        /// </summary>
        public string Title { get; set; }        
        /// <summary>
        /// The rating of the book
        /// </summary>
        public int Rating { get; set; }
    }
}
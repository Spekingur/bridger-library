namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// A basic model for a review.
    /// </summary>
    public class ReviewDTO
    {
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Name of the user that made the review
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The rating the user gave the book
        /// </summary>
        public int Rating { get; set; }
    }
}
using System;

namespace LibraryApp.Models.EntityModels
{
    /// <summary>
    /// Entity model for a review. Direct mapping to database.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Id of the review
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id of the book being reviewed
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// Id of the user that made the review
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// The rating the user gave the book
        /// From 0 to 10, representing 5 stars, 1 being half a star
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        /// Optional text review from the user
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Date of the review was made
        /// </summary>
        public DateTime PostDate { get; set; }
        /// <summary>
        /// Date of when the review was last updated
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
using System;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// More detailed model for a review.
    /// </summary>
    public class ReviewDetailsDTO
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
        /// <summary>
        /// A review text if the user gave one
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Date of when the review was first posted
        /// </summary>
        public DateTime PostDate { get; set; }
        /// <summary>
        /// Date of when the review was last updated or edited
        /// Generally the same as PostDate
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}
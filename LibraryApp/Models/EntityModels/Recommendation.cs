namespace LibraryApp.Models.EntityModels
{
    /// <summary>
    /// Entity model for a recommendation. Direct mapping to database.
    /// </summary>
    public class Recommendation
    {
        /// <summary>
        /// Id of the recommendation
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The id of the book being recommended
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// The id of the user getting the recommendation
        /// </summary>
        public int UserId { get; set; }
    }
}
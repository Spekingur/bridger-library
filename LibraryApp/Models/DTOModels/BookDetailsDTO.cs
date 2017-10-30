using System;
using System.Collections.Generic;

namespace LibraryApp.Models.DTOModels
{
    /// <summary>
    /// Book details exposed to users.
    /// </summary>
    public class BookDetailsDTO
    {
        public BookDetailsDTO() {
            Outloans = new List<OutloanListUsersDTO>();
            Reviews = new List<ReviewListUsersDTO>();
        }
        /// <summary>
        /// Id of the book
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Full name of author of book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Date of when book was released
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// ISBN number of the book
        /// </summary>
        public string Isbn { get; set; }
        /// <summary>
        /// Date of when the book was added to library
        /// </summary>
        public DateTime DateAdded { get; set; }
        /// <summary>
        /// Loan history of book
        /// </summary>
        public IEnumerable<OutloanListUsersDTO> Outloans { get; set; }
        /// <summary>
        /// Reviews of the book
        /// </summary>
        public IEnumerable<ReviewListUsersDTO> Reviews { get; set; }
    }
}
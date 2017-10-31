using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    /// <summary>
    /// Interface for reviews functions towards database
    /// </summary>
    public interface IReviewRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IEnumerable<ReviewDTO> GetReviewsUserHasMade(int userId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        ReviewDetailsDTO GetReviewDetails(int userId, int bookId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ReviewDTO> GetAllReviews();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId);

        ReviewDTO AddNewReview(int bookId, int userId, ReviewViewModel newReview);

        ReviewDetailsDTO UpdateBookReview(int userId, int bookId, ReviewViewModel updatedReview);

        bool RemoveBookReview(int bookId, int userId);
    }
}
using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Services
{
    public interface IReviewService
    {
        IEnumerable<ReviewDTO> GetReviewsUserHasMade(int userId);

        ReviewDetailsDTO GetReviewDetails(int userId, int bookId);

        IEnumerable<ReviewDTO> GetAllReviews();

        IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId);

        ReviewDTO AddNewReview(int bookId, int userId, ReviewViewModel newReview);

        ReviewDetailsDTO UpdateBookReview(int userId, int bookId, ReviewViewModel updatedReview);

        bool RemoveBookReview(int bookId, int userId);
    }
}
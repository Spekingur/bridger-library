using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Services
{
    public class ReviewService : IReviewService
    {
        public ReviewDTO AddNewReview(int bookId, int userId, ReviewViewModel newReview)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetAllReviews()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public ReviewDetailsDTO GetReviewDetails(int userId, int bookId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetReviewsUserHasMade(int userId)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveBookReview(int bookId, int userId)
        {
            throw new System.NotImplementedException();
        }

        public ReviewDetailsDTO UpdateBookReview(int userId, int bookId, ReviewViewModel updatedReview)
        {
            throw new System.NotImplementedException();
        }
    }
}
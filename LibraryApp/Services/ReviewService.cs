using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class ReviewService : IReviewService
    {
        private IReviewRepository _repo;

        public ReviewService(IReviewRepository repo)
        {
            _repo = repo;
        }

        public ReviewDTO AddNewReview(int bookId, int userId, ReviewViewModel newReview)
        {
            var review = _repo.AddNewReview(bookId, userId, newReview);
            return review;
        }

        public IEnumerable<ReviewDTO> GetAllReviews()
        {
            var reviews = _repo.GetAllReviews();
            return reviews;
        }

        public IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId)
        {
            var reviews = _repo.GetAllReviewsOfABook(bookId);
            return reviews;
        }

        public ReviewDetailsDTO GetReviewDetails(int userId, int bookId)
        {
            var review = _repo.GetReviewDetails(userId, bookId);
            return review;
        }

        public IEnumerable<ReviewDTO> GetReviewsUserHasMade(int userId)
        {
            var reviews = _repo.GetReviewsUserHasMade(userId);
            return reviews;
        }

        public bool RemoveBookReview(int bookId, int userId)
        {
            var removeReview = _repo.RemoveBookReview(bookId, userId);
            return removeReview;
        }

        public ReviewDetailsDTO UpdateBookReview(int userId, int bookId, ReviewViewModel updatedReview)
        {
            var updateReview = _repo.UpdateBookReview(userId, bookId, updatedReview);
            return updateReview;
        }
    }
}
using System.Collections.Generic;
using System;
using System.Linq;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using LibraryApp.Models.EntityModels;

namespace LibraryApp.Repositories
{
    /// <summary>
    /// Repository functions on database for reviews
    /// </summary>
    public class ReviewRepository : IReviewRepository
    {
        private AppDataContext _db;

        public ReviewRepository(AppDataContext db)
        {
            _db = db;
        }

        public ReviewDTO AddNewReview(int bookId, int userId, ReviewViewModel newReview)
        {
            var review = new Review
            {
                BookId = bookId,
                UserId = userId,
                Rating = newReview.Rating,
                Text = newReview.Text,
                PostDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            _db.Reviews.Add(review);
            _db.SaveChanges();

            return new ReviewDTO
            {
                Id = review.Id,
                Title = null,
                Name = null,
                Rating = review.Rating
            };
            
        }

        public IEnumerable<ReviewDTO> GetAllReviews()
        {
            var reviews = (from r in _db.Reviews
                            join b in _db.Books on r.BookId equals b.Id
                            join u in _db.Users on r.UserId equals u.Id
                            select new ReviewDTO
                            {
                                Id = r.Id,
                                Title = b.Title,
                                Name = u.Name,
                                Rating = r.Rating
                            }).ToList();
            return reviews;
        }

        public IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId)
        {
            var reviews = (from r in _db.Reviews
                                where r.BookId == bookId
                                join b in _db.Books on r.BookId equals b.Id
                                join u in _db.Users on r.UserId equals u.Id
                                select new ReviewDTO
                                {
                                    Id = r.Id,
                                    Title = b.Title,
                                    Name = u.Name,
                                    Rating = r.Rating
                                }).ToList();
            return reviews;
        }

        public ReviewDetailsDTO GetReviewDetails(int userId, int bookId)
        {
            var review = (from r in _db.Reviews
                            where (r.UserId == userId) && (r.BookId == bookId)
                            select new ReviewDetailsDTO
                            {
                                Id = r.Id,
                                Title = (from b in _db.Books
                                            where b.Id == bookId
                                            select b.Title).SingleOrDefault(),
                                Name = (from u in _db.Users
                                            where u.Id == userId
                                            select u.Name).SingleOrDefault(),
                                Rating = r.Rating,
                                Text = r.Text,
                                PostDate = r.PostDate,
                                UpdateDate = r.UpdateDate
                            }).SingleOrDefault();
            return review;
        }

        public IEnumerable<ReviewDTO> GetReviewsUserHasMade(int userId)
        {
            var reviews = (from r in _db.Reviews
                            where r.UserId == userId
                            join b in _db.Books on r.BookId equals b.Id
                            select new ReviewDTO
                            {
                                Id = r.Id,
                                Title = b.Title,
                                Name = (from u in _db.Users
                                            where u.Id == userId
                                            select u.Name).SingleOrDefault(),
                                Rating = r.Rating
                            });
            return reviews;
        }

        public bool RemoveBookReview(int bookId, int userId)
        {
            var review = (from r in _db.Reviews
                            where (r.BookId == bookId) && (r.UserId == userId)
                            select r).SingleOrDefault();
            
            if(review == null) { return false; }

            _db.Reviews.Remove(review);
            _db.SaveChanges();
            return true;
        }

        public ReviewDetailsDTO UpdateBookReview(int userId, int bookId, ReviewViewModel updatedReview)
        {
            var review = (from r in _db.Reviews
                            where (r.BookId == bookId) && (r.UserId == userId)
                            select r).SingleOrDefault();
            
            review.Rating = updatedReview.Rating;
            review.Text = updatedReview.Text;
            review.UpdateDate = DateTime.Now;
            _db.SaveChanges();

            return new ReviewDetailsDTO
            {
                Id = review.Id,
                Title = (from b in _db.Books
                            where b.Id == bookId
                            select b.Title).SingleOrDefault(),
                Name = (from u in _db.Users
                            where u.Id == userId
                            select u.Name).SingleOrDefault(),
                Rating = review.Rating,
                Text = review.Text,
                PostDate = review.PostDate,
                UpdateDate = review.UpdateDate
            };
        }
    }
}
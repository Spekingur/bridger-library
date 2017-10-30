using System;
using System.Collections.Generic;
using LibraryApp.Models.DTOModels;

namespace LibraryApp.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        public IEnumerable<BookDTO> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public BookDetailsDTO GetBookById(int bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int bookId)
        {
            throw new NotImplementedException();
        }

        public ReviewDetailsDTO GetReviewDetails(int userId, int bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewDTO> GetReviewsUserHasMade(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDetailsDTO GetUserById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}

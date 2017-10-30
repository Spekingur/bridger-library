using System;
using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        public BookDetailsDTO AddNewBook(BookViewModel newBook)
        {
            throw new NotImplementedException();
        }

        public OutloanDTO AddNewLoan(int userId, int bookId)
        {
            throw new NotImplementedException();
        }

        public ReviewDTO AddNewReview(int bookId, int userId, ReviewViewModel newReview)
        {
            throw new NotImplementedException();
        }

        public UserDetailsDTO AddNewUser(UserViewModel newUser)
        {
            throw new NotImplementedException();
        }

        public bool AdminRemoveUserFromDatabase(int userId)
        {
            throw new NotImplementedException();
        }

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

        public bool RemoveBookFromLibrary(int bookId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBookReview(int bookId, int userId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }

        public OutloanDetailsDTO ReturnBook(int userId, int bookId)
        {
            throw new NotImplementedException();
        }

        public BookDetailsDTO UpdateBook(int bookId, BookViewModel updatedBook)
        {
            throw new NotImplementedException();
        }

        public ReviewDetailsDTO UpdateBookReview(int userId, int bookId, ReviewViewModel updatedReview)
        {
            throw new NotImplementedException();
        }

        public OutloanDetailsDTO UpdateLoan(int userId, int bookId, LoanViewModel updateLoan)
        {
            throw new NotImplementedException();
        }

        public UserDetailsDTO UpdateUserInfo(int userId, UserViewModel updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}

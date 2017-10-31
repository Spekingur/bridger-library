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
            DateTime date1 = new DateTime(2016, 3, 6);
            DateTime date2 = new DateTime(2017, 12, 12);
            return new List<BookDTO> {
                new BookDTO {Id = 1, Title = "Book 1", Author = "Author 1", ReleaseDate = date1, Isbn = "Isbn 1"},
                new BookDTO {Id = 2, Title = "Book 2", Author = "Author 2", ReleaseDate = date2, Isbn = "Isbn 2"}
            };
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

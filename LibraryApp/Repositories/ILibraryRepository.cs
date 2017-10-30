using System.Collections.Generic;
using LibraryApp.Models.DTOModels;

namespace LibraryApp.Repositories
{
    public interface ILibraryRepository
    {
         IEnumerable<BookDTO> GetAllBooks();
         BookDetailsDTO GetBookById(int bookId);
         IEnumerable<UserDTO> GetAllUsers();
         UserDetailsDTO GetUserById(int userId);
         IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int bookId);
         IEnumerable<ReviewDTO> GetReviewsUserHasMade(int userId);
         ReviewDetailsDTO GetReviewDetails(int userId, int bookId);
         IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId);
         IEnumerable<ReviewDTO> GetAllReviews();
    }
}
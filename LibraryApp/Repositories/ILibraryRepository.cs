using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILibraryRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
         IEnumerable<BookDTO> GetAllBooks();
         /// <summary>
         /// 
         /// </summary>
         /// <param name="bookId"></param>
         /// <returns></returns>
         BookDetailsDTO GetBookById(int bookId);
         /// <summary>
         /// 
         /// </summary>
         /// <returns></returns>
         IEnumerable<UserDTO> GetAllUsers();
         /// <summary>
         /// 
         /// </summary>
         /// <param name="userId"></param>
         /// <returns></returns>
         UserDetailsDTO GetUserById(int userId);
         /// <summary>
         /// 
         /// </summary>
         /// <param name="bookId"></param>
         /// <returns></returns>
         IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int bookId);
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
         /// <param name="bookId"></param>
         /// <returns></returns>
         IEnumerable<ReviewDTO> GetAllReviewsOfABook(int bookId);
         /// <summary>
         /// 
         /// </summary>
         /// <returns></returns>
         IEnumerable<ReviewDTO> GetAllReviews();
         BookDetailsDTO AddNewBook(BookViewModel newBook);
         BookDetailsDTO UpdateBook(int bookId, BookViewModel updatedBook);
         UserDetailsDTO AddNewUser(UserViewModel newUser);
         UserDetailsDTO UpdateUserInfo(int userId, UserViewModel updatedUser);
         OutloanDTO AddNewLoan(int userId, int bookId);
         OutloanDetailsDTO ReturnBook(int userId, int bookId);
         OutloanDetailsDTO UpdateLoan(int userId, int bookId, LoanViewModel updateLoan);
         ReviewDTO AddNewReview(int bookId, int userId, ReviewViewModel newReview);
         ReviewDetailsDTO UpdateBookReview(int userId, int bookId, ReviewViewModel updatedReview);
         bool RemoveBookFromLibrary(int bookId);
         bool RemoveBookReview(int bookId, int userId);
         bool RemoveUser(int userId);
         bool AdminRemoveUserFromDatabase(int userId);
    }
}
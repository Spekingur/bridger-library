using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Services
{
    public interface IOutloanService
    {
        IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int userId);

        OutloanDTO AddNewLoan(int userId, int bookId);

        bool ReturnBook(int userId, int bookId);

        OutloanDetailsDTO UpdateLoan(int userId, int bookId, LoanViewModel updateLoan);
    }
}
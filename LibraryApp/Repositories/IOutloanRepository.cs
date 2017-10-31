using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    public interface IOutloanRepository
    {
        IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int bookId);

        OutloanDTO AddNewLoan(int userId, int bookId);

        OutloanDetailsDTO ReturnBook(int userId, int bookId);
        
        OutloanDetailsDTO UpdateLoan(int userId, int bookId, LoanViewModel updateLoan);
    }
}
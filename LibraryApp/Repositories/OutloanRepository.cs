using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    public class OutloanRepository : IOutloanRepository
    {
        public OutloanDTO AddNewLoan(int userId, int bookId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public OutloanDetailsDTO ReturnBook(int userId, int bookId)
        {
            throw new System.NotImplementedException();
        }

        public OutloanDetailsDTO UpdateLoan(int userId, int bookId, LoanViewModel updateLoan)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class OutloanService : IOutloanService
    {
        private IOutloanRepository _repo;
        
        public OutloanService(IOutloanRepository repo)
        {
            _repo = repo;
        }

        public OutloanDTO AddNewLoan(int userId, int bookId)
        {
            var loan = _repo.AddNewLoan(userId, bookId);
            return loan;
        }

        public IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int userId)
        {
            var loans = _repo.GetBooksUserHasInLoan(userId);
            return loans;
        }

        public bool ReturnBook(int userId, int bookId)
        {
            var bReturn = _repo.ReturnBook(userId, bookId);
            return bReturn;
        }

        public OutloanDetailsDTO UpdateLoan(int userId, int bookId, LoanViewModel updateLoan)
        {
            var lUpdate = _repo.UpdateLoan(userId, bookId, updateLoan);
            return lUpdate;
        }
    }
}
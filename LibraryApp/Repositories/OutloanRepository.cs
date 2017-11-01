using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.EntityModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    public class OutloanRepository : IOutloanRepository
    {
        private AppDataContext _db;

        public OutloanRepository(AppDataContext db)
        {
            _db = db;
        }

        public OutloanDTO AddNewLoan(int userId, int bookId)
        {
            var loan = new Outloan
            {
                BookId = bookId,
                UserId = userId,
                LoanDate = DateTime.Now,
                ReturnDate = null,
                Returned = false
            };

            _db.Outloans.Add(loan);
            _db.SaveChanges();

            return new OutloanDTO
            {
                Id = loan.Id,
                UserName = (from u in _db.Users
                                where u.Id == userId
                                select u.Name).SingleOrDefault(),
                BookTitle = (from b in _db.Books
                                where b.Id == bookId
                                select b.Title).SingleOrDefault(),
                LoanDate = loan.LoanDate
            };
        }

        public IEnumerable<BookLiteDTO> GetBooksUserHasInLoan(int userId)
        {
            var loans = (from l in _db.Outloans
                            where (l.UserId == userId) && (l.Returned == false)
                            join b in _db.Books on l.BookId equals b.Id
                            select new BookLiteDTO
                            {
                                Id = l.Id,
                                Title = b.Title,
                                Author = b.Author
                            }).ToList();
            
            return loans;
        }

        public bool ReturnBook(int userId, int bookId)
        {
            var loan = (from l in _db.Outloans
                            where (l.UserId == userId) && (l.BookId == bookId)
                            select l).SingleOrDefault();
            
            if(loan == null) { return false; }
            
            loan.ReturnDate = DateTime.Now;
            loan.Returned = true;
            _db.SaveChanges();
            return true;

            /*return new OutloanDetailsDTO
            {
                Name = (from u in _db.Users
                            where u.Id == userId
                            select u.Name).SingleOrDefault(),
                Title = (from b in _db.Books
                            where b.Id == bookId
                            select b.Title).SingleOrDefault(),
                LoanDate = loan.LoanDate,
                ReturnDate = loan.ReturnDate,
                Returned = loan.Returned
            };*/
        }

        public OutloanDetailsDTO UpdateLoan(int userId, int bookId, LoanViewModel updateLoan)
        {
            var loan = (from l in _db.Outloans
                            where (l.UserId == userId) && (l.BookId == bookId)
                            select l).SingleOrDefault();

            if(loan == null) { return null; }
            
            loan.BookId = updateLoan.BookId;
            loan.UserId = updateLoan.UserId;
            loan.LoanDate = updateLoan.LoanDate;
            loan.ReturnDate = updateLoan.ReturnDate;
            loan.Returned = updateLoan.Returned;

            _db.SaveChanges();
            
            return new OutloanDetailsDTO
            {
                Name = (from u in _db.Users
                            where u.Id == loan.UserId
                            select u.Name).SingleOrDefault(),
                Title = (from b in _db.Books
                            where b.Id == loan.BookId
                            select b.Title).SingleOrDefault(),
                LoanDate = loan.LoanDate,
                ReturnDate = loan.ReturnDate,
                Returned = loan.Returned
            };
        }
    }
}
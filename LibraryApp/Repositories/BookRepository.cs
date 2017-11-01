using System;
using System.Linq;
using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using LibraryApp.Models.EntityModels;

namespace LibraryApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private AppDataContext _db;

        public BookRepository(AppDataContext db)
        {
            _db = db;
        }

        public BookDetailsDTO AddNewBook(BookViewModel newBook)
        {
            var book = new Book
            {
                Title = newBook.Title,
                Author = newBook.Author,
                ReleaseDate = newBook.ReleaseDate,
                Isbn = newBook.Isbn,
                DateAdded = DateTime.Now
            };

            _db.Books.Add(book);
            _db.SaveChanges();

            return new BookDetailsDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                ReleaseDate = book.ReleaseDate,
                Isbn = book.Isbn,
                DateAdded = book.DateAdded
            };
        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            /*DateTime date1 = new DateTime(2016, 3, 6);
            DateTime date2 = new DateTime(2017, 12, 12);
            return new List<BookDTO> {
                new BookDTO {Id = 1, Title = "Book 1", Author = "Author 1", ReleaseDate = date1, Isbn = "Isbn 1"},
                new BookDTO {Id = 2, Title = "Book 2", Author = "Author 2", ReleaseDate = date2, Isbn = "Isbn 2"}
            };*/
            var books = (from b in _db.Books
                            select new BookDTO 
                            {
                                Id = b.Id,
                                Title = b.Title,
                                Author = b.Author,
                                ReleaseDate = b.ReleaseDate,
                                Isbn = b.Isbn
                            }).ToList();
            return books;
        }

        public BookDetailsDTO GetBookById(int bookId)
        {
            var book = (from b in _db.Books
                            where b.Id == bookId
                            select new BookDetailsDTO
                            {
                                Id = b.Id,
                                Title = b.Title,
                                Author = b.Author,
                                ReleaseDate = b.ReleaseDate,
                                Isbn = b.Isbn,
                                DateAdded = b.DateAdded,
                                Outloans = (from l in _db.Outloans
                                                where l.BookId == b.Id
                                                join u in _db.Users on l.UserId equals u.Id
                                                select new OutloanListUsersDTO
                                                {
                                                    Id = l.Id,
                                                    Name = u.Name,
                                                    LoanDate = l.LoanDate,
                                                    ReturnDate = l.ReturnDate
                                                }),
                                Reviews = (from r in _db.Reviews
                                                where r.BookId == b.Id
                                                join u in _db.Users on r.UserId equals u.Id
                                                select new ReviewListUsersDTO
                                                {
                                                    Id = r.Id,
                                                    Name = u.Name,
                                                    Rating = r.Rating
                                                })
                            }).SingleOrDefault();
            return book;
        }

        public bool RemoveBookFromLibrary(int bookId)
        {
            var book = (from b in _db.Books
                            where b.Id == bookId
                            select b).SingleOrDefault();
            
            if(book == null) { return false; }

            _db.Books.Remove(book);
            _db.SaveChanges();

            return true;
        }

        public BookDetailsDTO UpdateBook(int bookId, BookViewModel updatedBook)
        {
            var book = (from b in _db.Books
                            where b.Id == bookId
                            select b).SingleOrDefault();
            
            if(book == null) { return null; } 

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.ReleaseDate = updatedBook.ReleaseDate;
            book.Isbn = updatedBook.Isbn;

            _db.SaveChanges();

            return new BookDetailsDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                ReleaseDate = book.ReleaseDate,
                Isbn = book.Isbn,
                DateAdded = book.DateAdded,
                Outloans = (from l in _db.Outloans
                                where l.BookId == book.Id
                                join u in _db.Users on l.UserId equals u.Id
                                select new OutloanListUsersDTO
                                {
                                    Id = l.Id,
                                    Name = u.Name,
                                    LoanDate = l.LoanDate,
                                    ReturnDate = l.ReturnDate
                                }),
                Reviews = (from r in _db.Reviews
                                where r.BookId == book.Id
                                join u in _db.Users on r.UserId equals u.Id
                                select new ReviewListUsersDTO
                                {
                                    Id = r.Id,
                                    Name = u.Name,
                                    Rating = r.Rating
                                })
            };
        }
    }
}
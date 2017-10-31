using System;
using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _repo;

        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }
        
        public BookDetailsDTO AddNewBook(BookViewModel newBook)
        {
            var book = _repo.AddNewBook(newBook);
            return book;
        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            var books = _repo.GetAllBooks();
            return books;
        }

        public BookDetailsDTO GetBookById(int bookId)
        {
            var book = _repo.GetBookById(bookId);
            return book;
        }

        public bool RemoveBook(int bookId)
        {
            var book = _repo.RemoveBookFromLibrary(bookId);
            return book;
        }

        public BookDetailsDTO UpdateBookInfo(int bookId, BookViewModel updatedBook)
        {
            var book = _repo.UpdateBook(bookId,updatedBook);
            return book;
        }
    }
}

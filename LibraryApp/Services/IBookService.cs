using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Services
{
    /// <summary>
    /// Interface for book services
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// Get a list of all books
        /// </summary>
        /// <returns>A list of books</returns>
        IEnumerable<BookDTO> GetAllBooks();

        /// <summary>
        /// Gets details of one book by bookId
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>Book details</returns>
        BookDetailsDTO GetBookById(int bookId);

        /// <summary>
        /// Adds a new book to database
        /// </summary>
        /// <param name="newBook"></param>
        /// <returns>Book details that were added</returns>
        BookDetailsDTO AddNewBook(BookViewModel newBook);

        /// <summary>
        /// Update a book's information in the database
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="updatedBook"></param>
        /// <returns>Updated book details</returns>
        BookDetailsDTO UpdateBookInfo(int bookId, BookViewModel updatedBook);
        
        /// <summary>
        /// Removes a book from the database
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>True if successfully removed, false if not</returns>
        bool RemoveBook(int bookId);
    }
}
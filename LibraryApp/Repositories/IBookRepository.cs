using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    /// <summary>
    /// Interface for book repository functions to database
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Gets all books from the book table in database
        /// </summary>
        /// <returns>A list of all books</returns>
        IEnumerable<BookDTO> GetAllBooks();

        /// <summary>
        /// Gets a book from the database by given Id
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>Book details object</returns>
        BookDetailsDTO GetBookById(int bookId);

        /// <summary>
        /// Adds a new book to database
        /// </summary>
        /// <param name="newBook"></param>
        /// <returns>Book details object that was just added</returns>
        BookDetailsDTO AddNewBook(BookViewModel newBook);

        /// <summary>
        /// Update book details in database
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="updatedBook"></param>
        /// <returns>An update book details object</returns>
        BookDetailsDTO UpdateBook(int bookId, BookViewModel updatedBook);

        /// <summary>
        /// Remove a book from the database
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>True if book was successfully removed, false otherwise</returns>
        bool RemoveBookFromLibrary(int bookId);
    }
}
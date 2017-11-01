using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Models.ViewModels;
using LibraryApp.Services;

namespace API.Controllers
{
    [Route("books")]
    public class BookController : Controller
    {
        private IBookService _bookService;
        private IReviewService _reviewService;

        public BookController(IBookService bookService, IReviewService reviewService)
        {
            _bookService = bookService;
            _reviewService = reviewService;
        }

        // GET /books
        [HttpGet]
        [Route("")]
        public IActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        // GET /books/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);

            if(book == null) { return NotFound(); }

            return Ok(book);
        }

        // POST /books
        [HttpPost]
        [Route("", Name = "AddNewBook")]
        public IActionResult AddNewBook([FromBody]BookViewModel newBook)
        {
            if(newBook == null) { return BadRequest(); }
            if(!ModelState.IsValid) { return StatusCode(412); }

            var user = _bookService.AddNewBook(newBook);

            //return Ok(user);
            return Created($"/books/newBook.Id", newBook);
        }

        // PUT /books/5
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateBook(int id, [FromBody]BookViewModel updatedBook)
        {
            if(updatedBook == null) { return BadRequest(); }
            if(!ModelState.IsValid) { return StatusCode(412); }

            var book = _bookService.UpdateBookInfo(id, updatedBook);

            if(book == null) { return NotFound(); }

            return Ok(book);
        }

        // DELETE /books/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult RemoveBook(int id)
        {
            var success = _bookService.RemoveBook(id);
            
            if(!success) { return NotFound(); }
            
            return NoContent();
        }

        // GET /books/reviews
        [HttpGet]
        [Route("reviews")]
        public IActionResult GetAllReviews()
        {
            var reviews = _reviewService.GetAllReviews();
            return Ok(reviews);
        }

        // GET /books/5/reviews
        [HttpGet]
        [Route("{bookId}/reviews")]
        public IActionResult GetReviewByBookId(int bookId)
        {
            var reviews = _reviewService.GetAllReviewsOfABook(bookId);

            if(reviews == null) { return NotFound(); }
            return Ok(reviews);
        }

        // GET /books/5/reviews/2
        [HttpGet]
        [Route("{bookId}/reviews/{userId}")]
        public IActionResult GetReviewByBookIdAndUserId(int bookId, int userId)
        {
            var review = _reviewService.GetReviewDetails(userId, bookId);

            if(review == null) { return NotFound(); }

            return Ok(review);
        }

        // PUT /books/5/reviews/2
        [HttpPut]
        [Route("{bookId}/reviews/{userId}")]
        public IActionResult UpdateReview(int bookId, int userId, [FromBody]ReviewViewModel updatedReview)
        {
            if(updatedReview == null) { return BadRequest(); }
            if(!ModelState.IsValid) { return StatusCode(412); }

            var review = _reviewService.UpdateBookReview(userId, bookId, updatedReview);

            if(review == null) { return NotFound(); }
            return Ok(review);
        }

        // DELETE /books/5/reviews/2
        [HttpDelete]
        [Route("{bookId}/reviews/{userId}")]
        public IActionResult RemoveReview(int bookId, int userId)
        {
            var success = _reviewService.RemoveBookReview(bookId, userId);
            if(!success) { return NotFound(); }
            return NoContent();
        }
    }
}

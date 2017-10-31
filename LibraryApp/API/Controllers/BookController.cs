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

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
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
    }
}

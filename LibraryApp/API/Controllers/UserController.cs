using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Models.ViewModels;
using LibraryApp.Services;

namespace API.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        private IUserService _userService;
        private IOutloanService _outloanService;

        public UserController(IUserService userService, IOutloanService outloanService)
        {
            _userService = userService;
            _outloanService = outloanService;
        }

        // GET /users
        [HttpGet]
        [Route("")]
        public IActionResult GetUsers()
        {
            var users = _userService.GetAllActiveUsers();
            return Ok(users);
        }

        // GET /users/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST /users
        [HttpPost]
        [Route("", Name = "AddNewUser")]
        public IActionResult AddNewUser([FromBody]UserViewModel newUser)
        {
            if(newUser == null) { return BadRequest(); }
            if(!ModelState.IsValid) { return StatusCode(412); }

            var user = _userService.AddNewUser(newUser);

            return Ok(user);
        }

        // PUT /users/5
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateUserInfo(int id, [FromBody]UserViewModel updatedUser)
        {
            if(updatedUser == null) { return BadRequest(); }
            if(!ModelState.IsValid) { return StatusCode(412); }

            var user = _userService.UpdateUserInfo(id, updatedUser);

            if(user == null) { return NotFound(); }

            return Ok(user);
        }

        // DELETE /users/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult RemoveUser(int id)
        {
            var success = _userService.RemoveUser(id);

            if(!success) { return NotFound(); }

            return NoContent();
        }

        // GET /users/5/books
        [HttpGet]
        [Route("{userId}/books")]
        public IActionResult GetUserLoans(int userId)
        {
            var loans = _outloanService.GetBooksUserHasInLoan(userId);
            return Ok(loans);
        }

        // POST /users/5/books/2
        [HttpPost]
        [Route("{userId}/books/{bookId}")]
        public IActionResult AddNewLoan(int userId, int bookId)
        {
            var loan = _outloanService.AddNewLoan(userId, bookId);
            return Ok(loan);
        }

        // DELETE /users/5/books/2
        [HttpDelete]
        [Route("{userId}/books/{bookId}")]
        public IActionResult ReturnBook(int userId, int bookId)
        {
            var success = _outloanService.ReturnBook(userId, bookId);

            if(!success) { return NotFound(); }

            return Ok();
        }

        // PUT /users/5/books/2
        [HttpPut]
        [Route("{userId}/books/{bookId}")]
        public IActionResult UpdateLoan(int userId, int bookId, [FromBody]LoanViewModel updatedLoan)
        {
            if(updatedLoan == null) { return BadRequest(); }
            if(!ModelState.IsValid) { return StatusCode(412); }

            var loan = _outloanService.UpdateLoan(userId, bookId, updatedLoan);

            if(loan == null) { return NotFound(); }

            return Ok(loan);
        }

        // GET /users/5/reviews
        [HttpGet]
        [Route("{userId}/reviews")]
        public IActionResult GetUserReviews(int userId)
        {
            return Ok();
        }

        // GET /users/5/reviews/2
        [HttpGet]
        [Route("{userId}/reviews/{bookId}")]
        public IActionResult GetUserReviewForABook(int userId, int bookId)
        {
            return Ok();
        }

        // POST /users/5/reviews/2
        [HttpPost]
        [Route("{userId}/reviews/{bookId}")]
        public IActionResult AddNewReview(int userId, int bookId, [FromBody]ReviewViewModel newReview)
        {
            return Ok();
        }

        // DELETE /users/5/reviews/2
        [HttpDelete]
        [Route("{userId}/reviews/{bookId}")]
        public IActionResult RemoveReview(int userId, int bookId)
        {
            return Ok();
        }

        // PUT /users/5/reviews/2
        [HttpPut]
        [Route("{userId}/reviews/{bookId}")]
        public IActionResult UpdateReview(int userId, int bookId, [FromBody]ReviewViewModel updatedReview)
        {
            return Ok();
        }

        // GET /users/5/recommendation
        [HttpGet]
        [Route("{userId}/Recommendation")]
        public IActionResult GetRecommendations(int userId)
        {
            return Ok();
        }
    }
}

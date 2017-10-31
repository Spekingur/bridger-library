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

        public UserController(IUserService userService)
        {
            _userService = userService;
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
    }
}

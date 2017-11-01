using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.EntityModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    /// <summary>
    /// Database actions for users
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private AppDataContext _db;

        public UserRepository(AppDataContext db)
        {
            _db = db;
        }

        public UserDetailsDTO AddNewUser(UserViewModel newUser)
        {
            var user = new User
            {
                Name = newUser.Name, 
                Address = newUser.Address, 
                Email = newUser.Email, 
                Telephone = newUser.Telephone,
                Active = true,
                RegisterDate = DateTime.Now,
                Usergroup = newUser.Usergroup
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            var userAdded = (from u in _db.Users
                                where u.Id == user.Id
                                select u).SingleOrDefault();
            /*var loans = (from l in _db.Outloans
                            where l.UserId == user.Id
                            join b in _db.Books on l.BookId equals b.Id
                            select new OutloanListBooksDTO
                            {
                                Id = l.Id,
                                Title = b.Title,
                                LoanDate = l.LoanDate,
                                ReturnDate = l.ReturnDate
                            }).ToList();
            var reviews = (from r in _db.Reviews
                            where r.UserId == user.Id
                            join b in _db.Books on r.BookId equals b.Id
                            select new ReviewListBooksDTO
                            {
                                Id = r.Id,
                                Title = b.Title,
                                Rating = r.Rating
                            }).ToList();*/

            return new UserDetailsDTO
            {
                Id = userAdded.Id,
                Name = userAdded.Name,
                Address = userAdded.Address,
                Email = userAdded.Email,
                Telephone = userAdded.Telephone,
                RegisterDate = userAdded.RegisterDate,
                Usergroup = userAdded.Usergroup 
            };

        }

        public bool AdminRemoveUserFromDatabase(int userId)
        {
            var user = (from u in _db.Users
                            where u.Id == userId
                            select u).SingleOrDefault();

            if (user == null) { return false; }

            _db.Users.Remove(user);
            _db.SaveChanges();
            return true;
        }

        public IEnumerable<UserDTO> GetAllActiveUsers()
        {
            var users = (from u in _db.Users
                            where u.Active == true
                            select new UserDTO
                            {
                                Id = u.Id,
                                Name = u.Name,
                                Address = u.Address,
                                Email = u.Email,
                                Telephone = u.Telephone,
                                Usergroup = u.Usergroup
                            }).ToList();
            return users;
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            /*return new List<UserDTO> {
                new UserDTO {Id = 1, Name = "Name 1", Address = "Address 1", Email = "Email 1", Telephone = "111-2222", Usergroup = "Admin"},
                new UserDTO {Id = 2, Name = "Name 2", Address = "Address 2", Email = "Email 2", Telephone = "222-1111", Usergroup = "User"}
            };*/
            var users = (from u in _db.Users
                            select new UserDTO
                            {
                                Id = u.Id,
                                Name = u.Name,
                                Address = u.Address,
                                Email = u.Email,
                                Telephone = u.Telephone,
                                Usergroup = u.Usergroup
                            }).ToList();
            return users;
        }

        public UserDetailsDTO GetUserById(int userId)
        {
            var user = (from u in _db.Users
                            where (u.Id == userId) && (u.Active == true)
                            select new UserDetailsDTO
                            {
                                Id = u.Id,
                                Name = u.Name,
                                Address = u.Address,
                                Email = u.Email,
                                Telephone = u.Telephone,
                                RegisterDate = u.RegisterDate,
                                Usergroup = u.Usergroup,
                                Outloans = (from l in _db.Outloans
                                                where l.UserId == u.Id
                                                join b in _db.Books on l.BookId equals b.Id
                                                select new OutloanListBooksDTO
                                                {
                                                    Id = l.Id,
                                                    Title = b.Title,
                                                    LoanDate = l.LoanDate,
                                                    ReturnDate = l.ReturnDate
                                                }),
                                Reviews = (from r in _db.Reviews
                                                where r.UserId == u.Id
                                                join b in _db.Books on r.BookId equals b.Id
                                                select new ReviewListBooksDTO
                                                {
                                                    Id = r.Id,
                                                    Title = b.Title,
                                                    Rating = r.Rating
                                                })
                            }).SingleOrDefault();
            return user;
        }

        public bool RemoveUser(int userId)
        {
            var user = (from u in _db.Users
                            where (u.Id == userId) && (u.Active == true)
                            select u).SingleOrDefault();

            if(user == null) { return false; }

            user.Active = false;
            _db.SaveChanges();
            return true;
        }

        public UserDetailsDTO UpdateUserInfo(int userId, UserViewModel updatedUser)
        {
            var user = (from u in _db.Users
                            where u.Id == userId
                            select u).SingleOrDefault();
            
            if(user == null) { return null; }

            user.Name = updatedUser.Name;
            user.Address = updatedUser.Address;
            user.Email = updatedUser.Email;
            user.Telephone = updatedUser.Telephone;
            user.Usergroup = updatedUser.Usergroup;

            _db.SaveChanges();

            return new UserDetailsDTO
            {
                Id = user.Id,
                Name = user.Name,
                Address = user.Address,
                Email = user.Email,
                Telephone = user.Telephone,
                RegisterDate = user.RegisterDate,
                Usergroup = user.Usergroup,
                Outloans = (from l in _db.Outloans
                                where l.UserId == user.Id
                                join b in _db.Books on l.BookId equals b.Id
                                select new OutloanListBooksDTO
                                {
                                    Id = l.Id,
                                    Title = b.Title,
                                    LoanDate = l.LoanDate,
                                    ReturnDate = l.ReturnDate
                                }),
                Reviews = (from r in _db.Reviews
                                where r.UserId == user.Id
                                join b in _db.Books on r.BookId equals b.Id
                                select new ReviewListBooksDTO
                                {
                                    Id = r.Id,
                                    Title = b.Title,
                                    Rating = r.Rating
                                })
            };
        }
    }
}
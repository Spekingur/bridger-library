using System.Collections.Generic;
using System.Linq;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.EntityModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Repositories
{
    public class RecommendationRepository : IRecommendationRepository
    {
        private AppDataContext _db;

        public RecommendationRepository(AppDataContext db)
        {
            _db = db;
        }

        public RecommendationDTO AddNewRecommendation(int userId, RecommendationViewModel newRecommendation)
        {
            var newRec = new Recommendation
            {
                UserId = userId,
                BookId = newRecommendation.BookId
            };

            _db.Recommendations.Add(newRec);
            _db.SaveChanges();

            var book = (from b in _db.Books
                            where b.Id == newRec.BookId
                            select b).SingleOrDefault();

            return new RecommendationDTO
            {
                Id = newRec.Id,
                Title = book.Title,
                Author = book.Author
            };
        }

        public IEnumerable<RecommendationDTO> GetRecommendationsByUserId(int userId)
        {
            var reco = (from rec in _db.Recommendations
                        where rec.UserId == userId
                        join b in _db.Books on rec.BookId equals b.Id
                        select new RecommendationDTO
                        {
                            Id = rec.Id,
                            Title = b.Title,
                            Author = b.Author
                        }).ToList();
            return reco;
        }
    }
}
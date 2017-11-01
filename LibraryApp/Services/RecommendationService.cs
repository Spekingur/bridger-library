using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class RecommendationService : IRecommendationService
    {
        private IRecommendationRepository _repo;
        
        public RecommendationService(IRecommendationRepository repo)
        {
            _repo = repo;
        }

        public RecommendationDTO AddNewRecommendation(int userId, RecommendationViewModel newRecommendation)
        {
            var recommendation = _repo.AddNewRecommendation(userId, newRecommendation);
            return recommendation;
        }

        public IEnumerable<RecommendationDTO> GetRecommendationsByUserId(int userId)
        {
            var recommendations = _repo.GetRecommendationsByUserId(userId);
            return recommendations;
        }
    }
}
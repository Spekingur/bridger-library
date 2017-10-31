using System.Collections.Generic;
using LibraryApp.Models.DTOModels;

namespace LibraryApp.Repositories
{
    public class RecommendationRepository : IRecommendationRepository
    {
        public IEnumerable<RecommendationDTO> GetRecommendationsByUserId(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}
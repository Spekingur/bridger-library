using System.Collections.Generic;
using LibraryApp.Models.DTOModels;

namespace LibraryApp.Repositories
{
    public interface IRecommendationRepository
    {
        IEnumerable<RecommendationDTO> GetRecommendationsByUserId(int userId);
    }
}
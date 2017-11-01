using System.Collections.Generic;
using LibraryApp.Models.DTOModels;
using LibraryApp.Models.ViewModels;

namespace LibraryApp.Services
{
    public interface IRecommendationService
    {
        IEnumerable<RecommendationDTO> GetRecommendationsByUserId(int userId);

        RecommendationDTO AddNewRecommendation(int userId, RecommendationViewModel newRecommendation);
    }
}
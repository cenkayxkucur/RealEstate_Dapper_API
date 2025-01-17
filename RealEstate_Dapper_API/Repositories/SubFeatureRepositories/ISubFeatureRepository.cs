using RealEstate_Dapper_API.Dtos.SubFeatureDtos;

namespace RealEstate_Dapper_API.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}

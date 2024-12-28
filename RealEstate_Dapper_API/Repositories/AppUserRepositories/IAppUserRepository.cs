using RealEstate_Dapper_API.Dtos.AppUserDtos;

namespace RealEstate_Dapper_API.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);
    }
}

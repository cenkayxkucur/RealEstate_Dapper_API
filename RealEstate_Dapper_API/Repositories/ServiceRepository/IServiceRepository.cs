using RealEstate_Dapper_API.Dtos.ServiceDtos;

namespace RealEstate_Dapper_API.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllService();
        Task CreateService(CreateServiceDto createserviceDto);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDto updateserviceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}

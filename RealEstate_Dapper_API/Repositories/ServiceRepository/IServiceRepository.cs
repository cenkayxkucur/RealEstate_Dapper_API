using RealEstate_Dapper_API.Dtos.ServiceDtos;

namespace RealEstate_Dapper_API.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createserviceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateserviceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}

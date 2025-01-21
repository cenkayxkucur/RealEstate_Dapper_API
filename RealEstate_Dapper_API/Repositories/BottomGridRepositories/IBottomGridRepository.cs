using RealEstate_Dapper_API.Dtos.BottomGridDtos;
using RealEstate_Dapper_API.Dtos.ServiceDtos;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGrid();
        Task CreateBottomGrid(CreateBottomGridDto createbottomgridDto);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDto updatebottomgridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}

using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto categoryDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}

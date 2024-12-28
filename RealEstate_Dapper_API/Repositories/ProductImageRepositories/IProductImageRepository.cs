using RealEstate_Dapper_API.Dtos.ProductDetailDtos;
using RealEstate_Dapper_API.Dtos.ProductImageDto;

namespace RealEstate_Dapper_API.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}

using RealEstate_Dapper_API.Dtos.ProductDetailDtos;
using RealEstate_Dapper_API.Dtos.ProductDtos;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeByTrueAsync(int id);
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeByFalseAsync(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
        Task ProductDealOfTheDayStatusChangeToTrue(int id);
        Task ProductDealOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();

        Task CreateProduct(CreateProductDto createProductDto);

        Task <GetProductByProductIdDto> GetProductByProductId(int id);

        Task<GetProductDetailByIdDto> GetProductDetailByProductId(int id);
        Task<List<ResultProductWithSearchListDto>> ResultProductWithSearchList(string searchKeyValue, int propertyCategoryId, string city);
        Task<List<ResultProductWithCategoryDto>> GetProductByDealOfTheDayTrueWithCategoriesAsync();
    }
}

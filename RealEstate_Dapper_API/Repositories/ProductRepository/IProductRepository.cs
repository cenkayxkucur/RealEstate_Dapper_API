using RealEstate_Dapper_API.Dtos.ProductDtos;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertsListByEmployeeAsync(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
        void ProductDealOfTheDayStatusChangeToTrue(int id);
        void ProductDealOfTheDayStatusChangeToFalse(int id);

        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
    }
}

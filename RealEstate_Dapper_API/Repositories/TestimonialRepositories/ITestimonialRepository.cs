using RealEstate_Dapper_API.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_API.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}

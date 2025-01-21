using RealEstate_Dapper_API.Dtos.ContactDtos;

namespace RealEstate_Dapper_API.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContact();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        Task CreateContact(CreateContactDto createContactDto);
        Task DeleteContact(int id);
        Task UpdateContact(UpdateContactDto updateContactDto);
        Task<GetByIDContactDto> GetContact(int id);
    }
}

using RealEstate_Dapper_API.Dtos.ContactDtos;

namespace RealEstate_Dapper_API.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        void CreateContact(CreateContactDto createContactDto);
        void DeleteContact(int id);
        void UpdateContact(UpdateContactDto updateContactDto);
        Task<GetByIDContactDto> GetContact(int id);
    }
}

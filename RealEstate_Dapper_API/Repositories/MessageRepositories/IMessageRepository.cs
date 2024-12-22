using RealEstate_Dapper_API.Dtos.MessageDtos;

namespace RealEstate_Dapper_API.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id);
    }
}

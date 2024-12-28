using Dapper;
using RealEstate_Dapper_API.Dtos.AppUserDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;

        public AppUserRepository(Context context)
        {
            _context = context;
        }
        public async Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id)
        {
            string query = "Select * From AppUser Where UserId=@UserId";
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIdDto>(query, parameters);
                return values;
            }
        }
    }
}

using Dapper;
using RealEstate_Dapper_API.Dtos.BottomGridDtos;
using RealEstate_Dapper_API.Dtos.ProductDtos;
using RealEstate_Dapper_API.Dtos.ServiceDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public class BottomGridRepository:IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async void CreateBottomGrid(CreateBottomGridDto createbottomGridDto)
        {
            string query = "insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", createbottomGridDto.Icon);
            parameters.Add("@title", createbottomGridDto.Title);
            parameters.Add("@description", createbottomGridDto.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "Delete From BottomGrid Where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            string query = "Select * From BottomGrid Where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateBottomGrid(UpdateBottomGridDto updatebottomGridDto)
        {
            string query = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", updatebottomGridDto.Icon);
            parameters.Add("@title", updatebottomGridDto.Title);
            parameters.Add("@description", updatebottomGridDto.Description);
            parameters.Add("@bottomGridID", updatebottomGridDto.BottomGridID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

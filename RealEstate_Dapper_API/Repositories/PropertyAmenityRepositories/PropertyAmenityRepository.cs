using Dapper;
using RealEstate_Dapper_API.Dtos.PropertyAmenityDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;

        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id)
        {
            string query = "Select PropertyAmenityId,Title From PropertyAmenity Inner Join Amenity On Amenity.AmenityId=PropertyAmenity.AmenityId Where PropertyId =@PropertyId And Status = 1";
            var parameters = new DynamicParameters();
            parameters.Add("@PropertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDto>(query,parameters);
                return values.ToList();
            }
        }
    }
}

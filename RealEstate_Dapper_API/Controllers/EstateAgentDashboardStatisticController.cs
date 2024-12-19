using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardStatisticController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;

        public EstateAgentDashboardStatisticController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        [HttpGet("AllProductCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticRepository.AllProductCount());
        }
        [HttpGet("ProductCountByStatusFalse")]
        public IActionResult ProductCountBuStatusFalse(int id)
        {
            return Ok(_statisticRepository.ProductCountBuStatusFalse(id));
        }
        [HttpGet("ProductCountByEmployeeId")]
        public IActionResult ProductCountByEmployeeId(int id)
        {
            return Ok(_statisticRepository.ProductCountByEmployeeId(id));
        }
        [HttpGet("ProductCountByStatusTrue")]
        public IActionResult ProductCountByStatusTrue(int id)
        {
            return Ok(_statisticRepository.ProductCountByStatusTrue(id));
        }
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.BottomGridDtos;
using RealEstate_Dapper_API.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }
        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGrid();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            _bottomGridRepository.CreateBottomGrid(createBottomGridDto);
            return Ok("Veri başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            _bottomGridRepository.DeleteBottomGrid(id);
            return Ok("Veri başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            _bottomGridRepository.UpdateBottomGrid(updateBottomGridDto);
            return Ok("Veri başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var value = await _bottomGridRepository.GetBottomGrid(id);
            return Ok(value);
        }
    }
}

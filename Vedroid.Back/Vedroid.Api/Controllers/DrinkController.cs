using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vedroid.BLL.DTO;
using Vedroid.BLL.Interfaces;
using Vedroid.BLL.Services;

namespace Vedroid.Api.Controllers
{
    [ApiController]
    [Route("/drink")]
    public class DrinkController : Controller
    {
        private readonly IDrinkService _drinkService;
        public DrinkController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }
        [HttpGet("get")]
        public async Task<IEnumerable<DrinkDto>> GetAllDrinksAsync() => await _drinkService.GetAllDrinksAsync();

        [HttpPost("create")]
        public async Task<DrinkDto> CreateDrinkAsync(DrinkDto drinkDto) => await _drinkService.CreateDrinkAsync(drinkDto);

        [HttpGet("get/{id:int}")]
        public async Task<DrinkDto> GetDrinkByIdAsync(int id) => await _drinkService.GetDrinkByIdAsync(id);

        [HttpDelete("delete/{id:int}")]
        public async Task DeleteDrinkAsync(int id)
        {
            await _drinkService.DeleteDrinkByIdAsync(id);
        }

        [HttpPut("update")]
        public async Task UpdateDrinkAsync(DrinkDto drinkDto)
        {
            await _drinkService.UpdateDrinkAsync(drinkDto);
        }
        [HttpGet("pivo")]
        public async Task<DrinkDto> EbanutPivandepala() => await _drinkService.EbanutPivandepala();

        [HttpGet("get/{type}")]
        public async Task<IEnumerable<DrinkDto>> GetDrinksByType(string type) => await _drinkService.GetDrinksByType(type);

        [HttpGet("get/{name}")]
        public async Task<IEnumerable<DrinkDto>> GetDrinksByName(string name) => await _drinkService.GetDrinksByName(name);
    }
}
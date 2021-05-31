using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vedroid.BLL.DTO;
using Vedroid.BLL.Services;

namespace Vedroid.Api.Controllers
{
    [Controller]
    [Route("/drink")]
    public class DrinkController : Controller
    {
        private readonly DrinkService _drinkService;
        public DrinkController(DrinkService drinkService)
        {
            _drinkService = drinkService;
        }
        [HttpGet("get")]
        public async Task<IEnumerable<DrinkDto>> GetAllDrinksAsync()
        {
            var result = await _drinkService.GetAllDrinksAsync();
            return result;
        }

        [HttpPost("create")]
        public async Task<DrinkDto> CreateDrinkAsync(DrinkDto drinkDto)
        {
            return await _drinkService.CreateDrinkAsync(drinkDto);
        }

        [HttpGet("get/{id:int}")]
        public async Task<DrinkDto> GetDrinkByIdAsync(int id)
        {
            return await _drinkService.GetDrinkByIdAsync(id);
        }

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
    }
}
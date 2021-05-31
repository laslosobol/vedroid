using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vedroid.BLL.DTO;
using Vedroid.BLL.Services;

namespace Vedroid.Api.Controllers
{
    [Controller]
    [Route("/snack")]
    public class SnackController : Controller
    {
        private readonly SnackService _snackService;
        public SnackController(SnackService snackService)
        {
            _snackService = snackService;
        }
        [HttpGet("get")]
        public async Task<IEnumerable<SnackDto>> GetAllDrinksAsync()
        {
            return await _snackService.GetAllSnacksAsync();
        }

        [HttpPost("create")]
        public async Task<SnackDto> CreateDrinkAsync(SnackDto snackDto)
        {
            return await _snackService.CreateSnackAsync(snackDto);
        }

        [HttpGet("get/{id:int}")]
        public async Task<SnackDto> GetDrinkByIdAsync(int id)
        {
            return await _snackService.GetSnackByIdAsync(id);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task DeleteDrinkAsync(int id)
        {
            await _snackService.DeleteSnackByIdAsync(id);
        }

        [HttpPut("update")]
        public async Task UpdateDrinkAsync(SnackDto snackDto)
        {
            await _snackService.UpdateSnackAsync(snackDto);
        }
    }
}
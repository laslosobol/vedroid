using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vedroid.BLL.DTO;
using Vedroid.BLL.Mappers;
using Vedroid.DAL.Interfaces;

namespace Vedroid.BLL.Interfaces
{
    public interface IDrinkService
    {
        Task UpdateDrinkAsync(DrinkDto drinkDto);

        Task DeleteDrinkByIdAsync(int drinkId);

        Task<DrinkDto> CreateDrinkAsync(DrinkDto drinkDto);

        Task<DrinkDto> GetDrinkByIdAsync(int drinkId);

        Task<IEnumerable<DrinkDto>> GetAllDrinksAsync();

        Task<IEnumerable<DrinkDto>> GetDrinksByType(string type);
        Task<IEnumerable<DrinkDto>> GetDrinksByName(string name);
        Task<DrinkDto> EbanutPivandepala();
    }
}
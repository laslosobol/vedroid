using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vedroid.BLL.DTO;
using Vedroid.BLL.Interfaces;
using Vedroid.BLL.Mappers;
using Vedroid.DAL.Interfaces;

namespace Vedroid.BLL.Services
{
    public class DrinkService : IDrinkService
    {
        
        private IUnitOfWork _unitOfWork;
        private DrinkMapper _drinkMapper;

        public DrinkMapper DrinkMapper => _drinkMapper ??= new DrinkMapper();

        public DrinkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task UpdateDrinkAsync(DrinkDto drinkDto)
        {
            var entity = DrinkMapper.Map(drinkDto);
            _unitOfWork.DrinkRepository.Update(entity);

            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteDrinkByIdAsync(int drinkId)
        {
            var drinkEntityToDelete = await _unitOfWork.DrinkRepository.GetByIdAsync(drinkId);
            if (drinkEntityToDelete is null) 
                throw new NotExistException($"No drink with id:{drinkId} was found!");
            
            _unitOfWork.DrinkRepository.Delete(drinkEntityToDelete);

            await _unitOfWork.CommitAsync();
        }

        public async Task<DrinkDto> CreateDrinkAsync(DrinkDto drinkDto)
        {
            var drinkEntityToInsert = DrinkMapper.Map(drinkDto);
            await _unitOfWork.DrinkRepository.InsertAsync(drinkEntityToInsert);
            await _unitOfWork.CommitAsync();

            return DrinkMapper.Map(drinkEntityToInsert);
        }

        public async Task<DrinkDto> GetDrinkByIdAsync(int drinkId)
        {
            var entity = await _unitOfWork.DrinkRepository.GetByIdAsync(drinkId);
            if (entity is null) throw new NotExistException($"No drink with id:{drinkId} was found!");

            var drinkDto = DrinkMapper.Map(entity);
            
            return drinkDto;
        }

        public async Task<IEnumerable<DrinkDto>> GetAllDrinksAsync()
        {
            var entity = await _unitOfWork.DrinkRepository.GetAllAsync();
            var result = entity.Select(el => DrinkMapper.Map(el)).ToList();

            return result;
        }
    }
}
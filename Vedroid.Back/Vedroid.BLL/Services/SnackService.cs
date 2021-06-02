using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vedroid.BLL.DTO;
using Vedroid.BLL.Interfaces;
using Vedroid.BLL.Mappers;
using Vedroid.DAL.Interfaces;

namespace Vedroid.BLL.Services
{
    public class SnackService : ISnackService
    {
        private IUnitOfWork _unitOfWork;
        private SnackMapper _snackMapper;

        public SnackMapper SnackMapper => _snackMapper ??= new SnackMapper();

        public SnackService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task UpdateSnackAsync(SnackDto snackDto)
        {
            var entity = SnackMapper.Map(snackDto);
            _unitOfWork.SnackRepository.Update(entity);

            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteSnackByIdAsync(int snackId)
        {
            var snackEntityToDelete = await _unitOfWork.SnackRepository.GetByIdAsync(snackId);
            if (snackEntityToDelete is null) 
                throw new NotExistException($"No snack with id:{snackId} was found!");
            
            _unitOfWork.SnackRepository.Delete(snackEntityToDelete);

            await _unitOfWork.CommitAsync();
        }

        public async Task<SnackDto> CreateSnackAsync(SnackDto snackDto)
        {
            var snackEntityToInsert = SnackMapper.Map(snackDto);
            await _unitOfWork.SnackRepository.InsertAsync(snackEntityToInsert);
            await _unitOfWork.CommitAsync();

            return SnackMapper.Map(snackEntityToInsert);
        }

        public async Task<SnackDto> GetSnackByIdAsync(int snackId)
        {
            var entity = await _unitOfWork.SnackRepository.GetByIdAsync(snackId);
            if (entity is null) throw new NotExistException($"No snack with id:{snackId} was found!");

            var snackDto = SnackMapper.Map(entity);
            
            return snackDto;
        }

        public async Task<IEnumerable<SnackDto>> GetAllSnacksAsync()
        {
            var entity = await _unitOfWork.SnackRepository.GetAllAsync();
            var result = entity.Select(el => _snackMapper.Map(el)).ToList();

            return result;
        }
        
        public async Task<IEnumerable<SnackDto>> GetSnacksByType(string type)
        {
            var entity = await _unitOfWork.SnackRepository.GetAllAsync();
            var result = entity.Select(_ => SnackMapper.Map(_)).Where(_ => _.Type == type).ToList();

            return result;
        }
        public async Task<IEnumerable<SnackDto>> GetSnacksByName(string name)
        {
            var entity = await _unitOfWork.SnackRepository.GetAllAsync();
            var result = entity.Select(_ => SnackMapper.Map(_)).Where(_ => _.Type == name).ToList();

            return result;
        }
    }
}
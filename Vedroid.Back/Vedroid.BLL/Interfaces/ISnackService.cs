using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vedroid.BLL.DTO;

namespace Vedroid.BLL.Interfaces
{
    public interface ISnackService
    {
        Task UpdateSnackAsync(SnackDto snackDto);

        Task DeleteSnackByIdAsync(int snackId);

        Task<SnackDto> CreateSnackAsync(SnackDto snackDto);

        Task<SnackDto> GetSnackByIdAsync(int snackId);

        Task<IEnumerable<SnackDto>> GetAllSnacksAsync();
    }
}
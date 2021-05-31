using System.Threading.Tasks;
using Vedroid.DAL.Entities;

namespace Vedroid.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Drink> DrinkRepository { get; }
        IRepository<Snack> SnackRepository { get; }
        
        Task CommitAsync();
        Task RollbackAsync();
    }
}
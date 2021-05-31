using System;
using System.Threading.Tasks;
using Vedroid.DAL.Context;
using Vedroid.DAL.Entities;
using Vedroid.DAL.Interfaces;
using Vedroid.DAL.Repositories;

namespace Vedroid.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        private IRepository<Drink> _drinkRepository;
        public IRepository<Drink> DrinkRepository => _drinkRepository ??= new GenericRepository<Drink>(_context);
        
        private IRepository<Snack> _snackRepository;
        public IRepository<Snack> SnackRepository => _snackRepository ??= new GenericRepository<Snack>(_context);
        
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

        }


        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task RollbackAsync()
        {
            await _context.DisposeAsync();
        }

        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }
    }
}
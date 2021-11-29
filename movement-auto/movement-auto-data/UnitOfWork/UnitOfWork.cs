using movement_auto_data.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovementDbContext _context;

        public UnitOfWork(MovementDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

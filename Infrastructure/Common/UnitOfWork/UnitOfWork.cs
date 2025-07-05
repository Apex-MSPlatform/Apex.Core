using Domain.primitives;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Common.UnitOfWork
{
    public class UnitOfWork : IApexUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}

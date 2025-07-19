using Apex.Core.primitives;
using Microsoft.EntityFrameworkCore;

namespace Apex.Core.Common.UnitOfWork
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

namespace Apex.Core.primitives
{
    public interface IApexUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

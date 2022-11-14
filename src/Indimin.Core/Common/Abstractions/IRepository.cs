namespace Indimin.Core.Common.Abstractions
{
    public interface IRepository<T, TId> 
        where T : class
        where TId : struct
    {
        IQueryable<T> GetAll(CancellationToken ct);
        Task<T> TryAddAsync(T entity, CancellationToken ct);
        Task<T> TryUpdateAsync(T entity, CancellationToken ct);
        Task TryDeleteAsync(TId entityId, CancellationToken ct);
    }
}

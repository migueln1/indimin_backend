using Indimin.Core.Common.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Indimin.Infrastructure.Data.Repositories.Common
{
    public abstract class BaseRepository<T, TId> : IRepository<T, TId>
        where T : class
        where TId : struct
    {
        private readonly IndiminDbContext _context;
        public BaseRepository(IndiminDbContext context)
        {
            _context = context;
        }
        public virtual IQueryable<T> GetAll(CancellationToken ct)
            => _context.Set<T>().AsNoTracking().AsQueryable();

        public virtual async Task<T?> GetById(TId entityId, CancellationToken ct)
            => await _context.Set<T>().FindAsync(new object[] { entityId }, cancellationToken: ct);

        public virtual async Task<T> TryAddAsync(T entity, CancellationToken ct)
        {
            await _context.AddAsync(entity, ct);
            await _context.SaveChangesAsync(ct);
            return entity;
        }

        public async Task TryDeleteAsync(TId entityId, CancellationToken ct)
        {
            T? entity = await GetById(entityId, ct);
            if(entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync(ct);
            }
        }

        public async Task<T> TryEditAsync(T entity, CancellationToken ct)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync(ct);
            return entity;
        }
    }
}

using Indimin.Core.Common.Abstractions;
using Indimin.Core.Models;
using Indimin.Infrastructure.Data.Repositories.Common;

namespace Indimin.Infrastructure.Data.Repositories
{
    public class CitizenRepository : BaseRepository<Citizen, int>, IRepository<Citizen, int>
    {
        public CitizenRepository(IndiminDbContext context) : base(context)
        {
        }
    }
}

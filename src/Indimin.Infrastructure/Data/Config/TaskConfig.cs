using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Indimin.Infrastructure.Data.Config
{
    public class TaskConfig : IEntityTypeConfiguration<Core.Models.DailyTask>
    {
        public void Configure(EntityTypeBuilder<Core.Models.DailyTask> builder)
        {
            builder.Property(c => c.CreationDate)
                .HasDefaultValueSql("getDate()");
        }
    }
}

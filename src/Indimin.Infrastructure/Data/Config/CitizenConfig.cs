using Indimin.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Indimin.Infrastructure.Data.Config
{
    public class CitizenConfig : IEntityTypeConfiguration<Citizen>
    {
        public void Configure(EntityTypeBuilder<Citizen> builder)
        {
            builder.Property(c => c.CreationDate)
                .HasDefaultValueSql("getDate()");
        }
    }
}

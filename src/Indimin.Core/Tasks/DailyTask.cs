using Indimin.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace Indimin.Core.Models
{
    public class DailyTask : BaseEntity<int>
    {
        [Required]
        [MaxLength(60)]
        public string? Name { get; init; }
        public Priority Priority { get; init; } = (Priority)1;
        public bool Pinned { get; init; } = false;
        public int CitizenId { get; init; }
        public virtual Citizen? Citizen { get; init; }

    }
}

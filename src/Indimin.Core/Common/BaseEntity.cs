using System.ComponentModel.DataAnnotations.Schema;

namespace Indimin.Core.Common
{
    public abstract class BaseEntity<TId> where TId : struct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TId Id { get; init; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; init; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? ModificationDate { get; set; }
    }
}

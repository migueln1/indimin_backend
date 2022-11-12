namespace Indimin.Application.Common.DTOs
{
    public class EntityDto<TId> where TId : struct
    {
        public TId Id { get; init; }
        public DateTime CreationDate { get; init; }
    }
}

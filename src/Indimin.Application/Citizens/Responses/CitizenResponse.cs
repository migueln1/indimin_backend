using Indimin.Application.Common.DTOs;

namespace Indimin.Application.Responses
{
    public class CitizenResponse : EntityDto<int>
    {
        public string? Name { get; init; }
        public TaskResponse? TaskInfo { get; init; }
    }
}

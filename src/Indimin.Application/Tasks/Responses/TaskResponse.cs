using Indimin.Application.Common.DTOs;
using Indimin.Core.Common;

namespace Indimin.Application.Responses;

public class TaskResponse : EntityDto<int>
{
    public string? Name { get; init; }
    public Priority Priority { get; init; }
}


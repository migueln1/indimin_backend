using Indimin.Core.Common;

namespace Indimin.Application.Requests;

public class TaskRequest
{
    public string? Name { get; init; }
    public Priority Priority { get; init; }
}


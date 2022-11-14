using System.ComponentModel.DataAnnotations;

namespace Indimin.Application.Requests;
public class AddCitizenRequest
{
    [Required]
    public string? Name { get; init; }

    public TaskRequest? Task { get; init; }
}


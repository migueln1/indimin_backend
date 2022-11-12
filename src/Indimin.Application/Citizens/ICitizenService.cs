using Indimin.Application.Responses;
using OneOf;

namespace Indimin.Application.Citizens
{
    public interface ICitizenService
    {
        Task<OneOf<List<CitizenResponse>>> GetAllCitizens(CancellationToken ct);
    }
}

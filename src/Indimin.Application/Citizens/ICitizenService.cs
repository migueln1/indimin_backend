using Indimin.Application.Citizens.Requests;
using Indimin.Application.Requests;
using Indimin.Application.Responses;
using OneOf;

namespace Indimin.Application.Citizens
{
    public interface ICitizenService
    {
        Task<OneOf<List<CitizenResponse>>> GetAllCitizens(CancellationToken ct);
        Task<CitizenResponse> TryAddCitizen(AddCitizenRequest entity, CancellationToken ct);
        Task<CitizenResponse> TryUpdateCitizen(UpdateCitizenRequest req, CancellationToken ct);
    }
}

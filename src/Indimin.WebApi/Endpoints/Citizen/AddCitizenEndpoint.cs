using Indimin.Application.Citizens;
using Indimin.Application.Requests;
using Indimin.Application.Responses;

namespace Indimin.WebApi.Endpoints
{
    public class AddCitizenEndpoint : Endpoint<AddCitizenRequest, CitizenResponse>
    {
        private readonly ICitizenService _citizenService;

        public AddCitizenEndpoint(ICitizenService citizenService)
        {
            _citizenService = citizenService;
        }

        public override void Configure()
        {
            Post("/citizens");
            AllowAnonymous();
            Options(x => x.RequireCors(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
        }
        public override async Task HandleAsync(AddCitizenRequest req, CancellationToken ct)
        {
            var actionResult = await _citizenService.TryAddCitizen(req, ct);

            await SendAsync(actionResult, cancellation: ct);
        }
    }
}

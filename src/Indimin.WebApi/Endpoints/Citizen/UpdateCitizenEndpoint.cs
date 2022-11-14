using Indimin.Application.Citizens;
using Indimin.Application.Citizens.Requests;
using Indimin.Application.Responses;

namespace Indimin.WebApi.Endpoints
{
    public class UpdateCitizenEndpoint : Endpoint<UpdateCitizenRequest, ApiResponse>
    {
        private readonly ICitizenService _citizenService;

        public UpdateCitizenEndpoint(ICitizenService citizenService)
        {
            _citizenService = citizenService;
        }

        public override void Configure()
        {
            Put("/citizens");
            AllowAnonymous();
        }
        public override async Task HandleAsync(UpdateCitizenRequest req, CancellationToken ct)
        {
            var entity = await _citizenService.TryUpdateCitizen(req, ct);
            await SendAsync(new ApiResponse(entity), cancellation: ct);
        }
    }
}

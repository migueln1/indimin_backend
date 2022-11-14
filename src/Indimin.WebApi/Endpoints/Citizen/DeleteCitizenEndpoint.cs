using Indimin.Application.Responses;
using Indimin.Core.Common.Abstractions;
using Indimin.Core.Models;

namespace Indimin.WebApi.Endpoints
{
    public class DeleteCitizenEndpoint : EndpointWithoutRequest<ApiResponse>
    {
        private readonly IRepository<Citizen, int> _repository;

        public DeleteCitizenEndpoint(IRepository<Citizen, int> repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Delete("/citizens/{CitizenId}");
            AllowAnonymous();
        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            try
            {
                int citizenId = Route<int>("CitizenId");
                await _repository.TryDeleteAsync(citizenId, ct);
                await SendAsync(new ApiResponse(new { Id = citizenId }), cancellation: ct);
            }
            catch (Exception)
            {
                await SendErrorsAsync(cancellation: ct);
            }
        }
    }
}

using Indimin.Application.Responses;
using Indimin.Core.Common.Abstractions;
using Indimin.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Indimin.WebApi.Endpoints
{
    public class ListCitizensEndpoint : EndpointWithoutRequest<ApiResponse>
    {
        private readonly IRepository<Citizen, int> _repository;

        public ListCitizensEndpoint(IRepository<Citizen, int> repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Get("/citizens");
            AllowAnonymous();
        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            var citizens = await _repository.GetAll(ct).ToListAsync(ct);
            await SendAsync(new ApiResponse(citizens), cancellation: ct);
        }
    }
}

using Indimin.Application.Requests;
using Indimin.Application.Responses;
using OneOf;
using Indimin.Core.Models;
using Indimin.Core.Common.Abstractions;
using Mapster;
using Indimin.Application.Citizens.Requests;

namespace Indimin.Application.Citizens
{
    public class CitizenService : ICitizenService
    {
        private readonly IRepository<Citizen, int> _repository;

        public CitizenService(IRepository<Citizen, int> repository)
        {
            _repository = repository;
        }

        public Task<OneOf<List<CitizenResponse>>> GetAllCitizens(CancellationToken ct)
        {
            throw new NotImplementedException();
        }

      

        public async Task<CitizenResponse> TryAddCitizen(AddCitizenRequest input, CancellationToken ct)
        {
            var entity = input.CitizenWithInitTask();
            var result = await _repository.TryAddAsync(entity, ct);

            return result.Adapt<CitizenResponse>();
        }

        public async Task<CitizenResponse> TryUpdateCitizen(UpdateCitizenRequest req, CancellationToken ct)
        {
            var result = await _repository.TryUpdateAsync(req.Adapt<Citizen>(), ct);
            return result.Adapt<CitizenResponse>();
        }
    }
}

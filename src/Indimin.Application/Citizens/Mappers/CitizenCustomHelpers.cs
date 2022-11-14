using Indimin.Application.Requests;
using Indimin.Core.Models;
using Mapster;

namespace Indimin.Application.Citizens
{
    public static class CitizenCustomHelpers
    {
        public static Citizen CitizenWithInitTask(this AddCitizenRequest input)
        {
            Citizen entity = input.Adapt<Citizen>();

            if (input.Task == null) return entity;

            entity.AddTask(input.Task.Adapt<DailyTask>());

            return entity;
        }
    }
}

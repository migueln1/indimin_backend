using Indimin.Core.Common;
using static System.Reflection.Metadata.BlobBuilder;

namespace Indimin.Core.Models
{
    public class Citizen : BaseEntity<int>
    {
        private readonly HashSet<DailyTask> tasks;
        public Citizen()
        {
            tasks = new HashSet<DailyTask>();
        }
        public string Name { get; private set; } = "N/D";
        public IReadOnlyCollection<DailyTask> Tasks => tasks;
        public void UpdateName(string name)
        {
            Name = name;
        }
        public void AddTask(DailyTask task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(DailyTask task)
        {
            tasks.Remove(task);
        }
    }
}

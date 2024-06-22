using System.Globalization;

namespace Domain.Entities.Models
{
    public class Shift
    {
        public Guid Id { get; set; }
        public string ShiftType { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public ICollection<Worker>? Workers { get; set; }
    }
}
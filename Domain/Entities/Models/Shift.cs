using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Shift
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DayOfWeek Day { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public ICollection<Worker>? Workers { get; set; }
    }
}
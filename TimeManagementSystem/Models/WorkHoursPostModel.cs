using TimeManaementSystem.Core.Entities;

namespace TimeManagementSystem.Api.Models
{
    public class WorkHoursPostModel
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Request { get; set; }
    }
}

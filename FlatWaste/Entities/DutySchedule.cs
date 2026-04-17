using System.ComponentModel.DataAnnotations;

namespace FlatWaste.Entities
{
    public class DutySchedule
    {
        public int Id { get; set; }
        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; } = null!;
        public DateTime ScheduledDate { get; set; }
        public int CycleNumber { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime? CompletedAt { get; set; }
    }
}

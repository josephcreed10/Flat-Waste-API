using System.ComponentModel.DataAnnotations;

namespace FlatWaste.Entities
{
    public class DutySchedule
    {
        public int Id { get; set; }
        public int AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
        public DateTime ScheduledDate { get; set; }
        [Required]
        public required string Status { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}

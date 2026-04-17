namespace FlatWaste.Models.DTOs
{
    public class DutyScheduleReadDTO
    {
        public int Id { get; set; }
        public int AssignedUserId { get; set; }
        public required UserReadDTO AssignedUser { get; set; } 
        public DateTime ScheduledDate { get; set; }
        public int CycleNumber { get; set; }
        public required string Status { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}

using FlatWaste.Entities;
using System.ComponentModel.DataAnnotations;

namespace FlatWaste.Models.DTOs
{
    public class DutyScheduleCreateDTO
    {
        public int AssignedUserId { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}

using FlatWaste.Entities;
using System.ComponentModel.DataAnnotations;

namespace FlatWaste.Models.DTOs
{
    public class DutyScheduleCreateDTO
    {
        public DateTime ScheduledDate { get; set; }
        public required string Status { get; set; }
    }
}

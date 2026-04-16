using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatWaste.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        public required string PasswordHash { get; set; }
        public string? Role { get; set; }
        public int? FlatId {  get; set; }
        public Flat? Flat { get; set; }
        public ICollection<DutySchedule>? DutySchedules { get; set; }


    }
}

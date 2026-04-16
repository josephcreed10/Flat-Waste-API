using System.ComponentModel.DataAnnotations;

namespace FlatWaste.Entities
{
    public class Flat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}

namespace FlatWaste.Models.DTOs
{
    public class UserReadDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Role { get; set; }
    }
}

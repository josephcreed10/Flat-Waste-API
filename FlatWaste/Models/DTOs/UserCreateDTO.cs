using FlatWaste.Entities;
using System.ComponentModel.DataAnnotations;

namespace FlatWaste.Models.DTOs
{
    public class UserCreateDTO
    {
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? Role { get; set; }

    }
}

using FlatWaste.Entities;
using System.ComponentModel.DataAnnotations;

namespace FlatWaste.Models.DTOs
{
    public class FlatReadDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}

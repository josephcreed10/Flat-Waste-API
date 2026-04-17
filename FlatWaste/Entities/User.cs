using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatWaste.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int RotationOrder { get; set; }
        public int CreditBalance { get; set; } = 0;
        public ICollection<DutySchedule> Duties { get; set; } = new List<DutySchedule>();
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class Note : LifeCycleEntity
    {
        public int Id { get; set; }
        [ForeignKey("Machine")]
        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; }
        public string? Description { get; set; }
        public DateTime? AttachedAt { get; set; }
    }
}

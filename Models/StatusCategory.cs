using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class StatusCategory: LifeCycleEntity
    {
        public int Id { get; set; }
        public MachineStatus Status { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string? Group { get; set; }

        public virtual Factory Factory { get; set; }
        [ForeignKey("Factory")]
        public int FactoryId { get; set; }

        public int? fp_core_Id { get; set; }

        public string FullName { get { return Status.ToString() + ": " + Name; } }
    }

    public enum MachineStatus
    {
        DownTime = 0, UpTime = 1
    }

    public class StatusCategoryViewModel
    {
        public int ParentId { get; set; }
        public StatusCategory MainModel { get; set; }
        public List<StatusCategory> Children { get; set; }
    }
}

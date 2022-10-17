namespace ShiftWorx.Models
{
    public class Attachment : LifeCycleEntity
    {
        public int Id { get; set; }    
        public AttachmentType AttachmentType { get; set; }
        public DateTime? AttachedAt { get; set; }
        public DateTime? DetachedAt { get; set; }
        public virtual Machine Machine { get; set; }
        public int MachineId { get; set; }
        public int? CollectorId { get; set; }
        public string? CollecterName { get; set; }

        public virtual StatusCode? AttachedStatusCode { get; set; }
        public int? AttachedStatusCodeId { get; set; }
        public virtual Job? AttachedJob { get; set; }
        public int? AttachedJobId { get; set; }
        // TODO: add AttachedUser and then update Type


        public int? fp_core_Id { get; set; }

        public string Type
        {
            get
            {
                string type = "";
                if (AttachedStatusCode != null)
                    type = "OperationCode";
                else if (AttachedJob != null)
                    type = "JOb";
                return type;
            }
        }
        public bool IsAttached { get { return AttachedAt != null && AttachedAt.HasValue && AttachedAt.Value < DateTime.UtcNow && (DetachedAt == null || !DetachedAt.HasValue || DetachedAt.Value > DateTime.UtcNow); } }
        public TimeSpan Period { get { return AttachedAt != null && DetachedAt != null ? (DetachedAt.Value - AttachedAt.Value) : TimeSpan.Zero; } }
    }

    public enum AttachmentType
    {
        Planned  = 1, InProgress = 2
    }
}

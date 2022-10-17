using ShiftWorx.Data;

namespace ShiftWorx.Models
{
    public class LifeCycleEntity 
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get { return DeletedAt != null; } }        

        public LifeCycleEntity()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }
    }
}

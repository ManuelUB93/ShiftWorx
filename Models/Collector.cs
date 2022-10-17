using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class Collector : LifeCycleEntity
    {
        public int Id { get; set; }
        [ForeignKey("Machine")]
        public int? MachineId { get; set; }
        public Machine? Machine { get; set; }

        public int FPHardwareId { get; set; }
        
        [MaxLength(256)]
        public string Name { get; set; }
        public string? Description { get; set; }

        public int fp_data_source_Id { get; set; } // temporarily added for migration from mySql 


        public virtual ICollection<CollectorData> CollectorData { get; set; }

        public Collector()
        {
            CollectorData = new List<CollectorData> ();            
        }
    }    
}
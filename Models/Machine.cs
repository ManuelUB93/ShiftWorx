using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace ShiftWorx.Models
{
    public class Machine : LifeCycleEntity
    {

        public int Id { get; set; }
        public int? FactoryId { get; set; }
        public virtual Factory? Factory { get; set; }

        //Basic Info
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Group { get; set; }     
 
        //Data For Bluebar
        public string? Datasourceforbb { get; set; }
        public bool isBBActive { get; set; } = false;

        //ShiftWorx Data
        public int fp_core_Id { get; set; } // temporarily added for migration from mySql
        [MaxLength(64)]
        public string? RemoteAddress { get; set; }
        //Collections
        public virtual ICollection<Collector> Collectors { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public Machine()
        {
            Collectors = new List<Collector>();
            Attachments = new List<Attachment>();
        }
    }
}
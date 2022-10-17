using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class Layout : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public bool IsReporting { get; set; }

        public Factory? Factory { get; set; }
        [ForeignKey("Factory")]
        public int? FactoryId { get; set; }

        //public ApplicationUser User { get; set; }
        public string UserName { get; set; }

        public FreePointProduct? FreePointProduct { get; set; }

        [ForeignKey("FreePointProduct")]
        public int? FreePointProductId { get; set; }

        public virtual ICollection<Panel>? Panels { get; set; } 


        public int fp_core_id { get; set; }
    }
}
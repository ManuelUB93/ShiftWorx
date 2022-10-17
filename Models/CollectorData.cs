using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class CollectorData : LifeCycleEntity
    {
        public int Id { get; set; }
        [ForeignKey("Collector")]
        public int CollectorId { get; set; }
        public Collector Collector { get; set; }

        [MaxLength(256)]
        public string? ValueString { get; set; }
        public bool ValueBool { get; set; }
        public Double ValueDouble { get; set; }
    }
}
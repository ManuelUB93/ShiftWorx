using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    /* in the table, 'data_sources' of the previous system
        1. 'type_id = 5' 
            => the data is about company(its parent_id = 1) or factory.
            (Volcan has one factory which has 2 factories)
     */

    public class Factory : LifeCycleEntity
    {
        public int Id { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        // basic info
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }                
        public string? Description { get; set; }
        public string? DefaultLayout { get; set; }
        public string? Group { get; set; }

        
        // location info
        [MaxLength(03)]
        public string Latitude { get; set; }
        [MaxLength(03)]
        public string Longitude { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        // technical info        
        public bool IsActive { get; set; }

        // from fp_core.activity_filters_and_modifiers
        public int? MinimumActivityFilter { get; set; }
        public int? MinimumInactivityFilter { get; set; }
        public int? MinimumActivityModifier { get; set; }
        public int? MaximumActivityModifier { get; set; }

        // uneditable (display only)
        [MaxLength(60)]
        public string FactoryKey { get; set; }
        public int fp_core_Id { get; set; }

        public ICollection<Layout> Layouts { get; set; }
        public ICollection<Machine> Machines { get; set; }
        public ICollection<JobTemplate> JobTemplates { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<StatusCategory> Categories { get; set; }
        public ICollection<FactoryOption> FactoryOptions { get; set; }

        public Factory()
        {
            Machines = new List<Machine>();
            JobTemplates = new List<JobTemplate>();
            Jobs = new List<Job>();
            Categories = new List<StatusCategory>();
            Layouts = new List<Layout>();            
        }
    }
}

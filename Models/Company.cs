using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShiftWorx.Models
{
    public class Company : LifeCycleEntity
    {
        public int Id { get; set; }

        // basic info
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        public string? Description { get; set; }

    
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


        // related with factory
        // uneditable
        [MaxLength(60)]
        public string FactoryKey { get; set; }
        public bool IsActive { get; set; }
        public int? MinimumActivityFilter { get; set; }
        public int? MinimumInactivityFilter { get; set; }
        public int? MinimumActivityModifier { get; set; }
        public int? MaximumActivityModifier { get; set; }
        public int fp_core_Id { get; set; }

        public ICollection<Factory> Factories { get; set; }

        public Company()
        {
            Factories = new List<Factory>();
        }
    }
}

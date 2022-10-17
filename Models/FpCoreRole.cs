namespace ShiftWorx.Models
{
    /// <summary>
    /// temporary use to store lagacy roles' information and relationships
    /// </summary>
    public class FpCoreRole: LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }
        public bool IsHidden { get; set; }
        public bool? IsLocked { get; set; }

        public int fp_core_Id { get; set; }
    }
}

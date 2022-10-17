namespace ShiftWorx.Models
{
    /// <summary>
    /// temporary use to store lagacy users' information and relationships
    /// </summary>
    public class FpCoreUser : LifeCycleEntity
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string Email { get; set; }
        public string? DisplayName { get; set; }
        public bool IsActive { get; set; }
        public FpCoreRole Role { get; set; }
        public int RoleId { get; set; }

        public int fp_core_Id { get; set; }
    }
}

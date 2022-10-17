namespace ShiftWorx.Models
{
    public class FreePointProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool Hide { get; set; }

        public int fp_core_id { get; set; }
    }
}

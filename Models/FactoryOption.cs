using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShiftWorx.Models
{
    public class FactoryOption : LifeCycleEntity
    {
        public int Id { get; set; }
        // factory options which came from the table, 'company_options' in mysql
        [Display(Name = "Language", Prompt = "ex) en, fr, es, sv, de, or it", Description = "Language")]
        public string? Language { get; set; }
        //[RegularExpression(@"^[a-z][a-z]-[a-zA-Z][a-zA-Z]")]
        [Display(Name = "Locale", Prompt = "ex) en-CA, or en-US", Description = "Locale")]
        public string? Locale { get; set; }
        [Display(Name = "Time Zone", Prompt = "ex) EST, or Canada/Eastern", Description = "Time Zone")]
        public string? TimeZone { get; set; }
        public string? JsonData { get; set; }
        public string? ProductName { get; set; }
    }
}

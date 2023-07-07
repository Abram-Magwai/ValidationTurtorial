using System.ComponentModel.DataAnnotations;
using ValidationTurtorial.Attributes;

namespace ValidationTurtorial.Models
{
    [SchoolLevelValidator]
    public class User
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get;set; }

        [Display(Name = "School Level")]
        public string SchoolLevel { get; set;} = null!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace NASA.Core.Models.Teacher
{
    public class BecomeTeacher
    {
        [Required]
        [StringLength(20, MinimumLength = 10)]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(15, MinimumLength = 7)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}

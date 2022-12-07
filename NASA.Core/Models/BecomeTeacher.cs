using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA.Core.Models
{
    public class BecomeTeacher
    {
        [Required]
        [StringLength(20, MinimumLength = 10)]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(15, MinimumLength = 7)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}

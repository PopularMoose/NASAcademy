
using NASA.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace NASA.Core.Models.Course
{
    public class CourseModel : ICourse
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string Title { get; set; } = null!;

        

        [Required]
        [StringLength(500, MinimumLength = 50)]
        public string Description { get; set; } = null!;

      

        [Required]
        [Display(Name = "Price per course")]
        [Range(0.00, 2000.00, ErrorMessage = "Price per course must be a positive number and less than {2} leva")]
        public decimal PricePerCourse { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CourseCategory> CourseCategories { get; set; } = new List<CourseCategory>();
    }
}

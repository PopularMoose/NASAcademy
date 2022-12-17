using NASA.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace NASA.Core.Models.Course
{
    public class CourseServiceModel : ICourse
    {
        public int Id { get; init; }

        public string Title { get; init; } = null!;


        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = null!;

        [Display(Name = "Price per course")]
        public decimal PricePerCourse { get; init; }

        [Display(Name = "Is Booked")]
        public bool IsBooked { get; init; }
    }
}

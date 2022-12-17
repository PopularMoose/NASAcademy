using NASA.Core.Contracts;

namespace NASA.Core.Models.Course
{
    public class CourseHome : ICourse
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

    }
}

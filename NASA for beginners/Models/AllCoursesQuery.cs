using NASA.Core.Models.Course;

namespace NASA_for_beginners.Models
{
    public class AllCoursesQuery
    {
        public const int CoursesPerPage = 3;

        public string? Category { get; set; }

        public string? SearchTerm { get; set; }

        public CourseSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalCoursesCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<CourseServiceModel> Courses { get; set; } = Enumerable.Empty<CourseServiceModel>();
    }
}

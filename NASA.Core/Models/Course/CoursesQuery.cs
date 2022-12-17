namespace NASA.Core.Models.Course
{
    public class CoursesQuery
    {
        public int TotalCoursesCount { get; set; }

        public IEnumerable<CourseServiceModel> Courses { get; set; } = new List<CourseServiceModel>();


    }
}

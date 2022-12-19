using NASA.Core.Models.Course;

namespace NASA_for_beginners.Areas.Admin.Models
{
    public class MyCourseViewModel
    {
        public IEnumerable<CourseServiceModel> AddedCourses { get; set; }

      = new List<CourseServiceModel>();

        public IEnumerable<CourseServiceModel> BookedCourses { get; set; }

        = new List<CourseServiceModel>();

    }
}

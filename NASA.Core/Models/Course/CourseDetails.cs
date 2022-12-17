using NASA.Core.Models.Teacher;

namespace NASA.Core.Models.Course
{
    public class CourseDetails : CourseServiceModel
    {
        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;

        public TeacherServiceModel Teacher { get; set; }
    }
}

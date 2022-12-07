using System.ComponentModel.DataAnnotations;

namespace NASA_for_beginners.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Courses = new List<Course>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public List<Course> Courses { get; set; }
    }
}

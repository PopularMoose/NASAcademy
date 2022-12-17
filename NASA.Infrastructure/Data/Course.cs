using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASA.Infrastructure.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;


        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; } = null!;


        [Required]
        [StringLength(500)]
        public string Description { get; set; } = null!;

       

        [Required]
        [Column(TypeName = "money")]
        [Precision(18,2)]
        public decimal PricePerCourse { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }

        public string? StudentId { get; set; } 

        [ForeignKey(nameof(StudentId))]
        public IdentityUser? Student { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

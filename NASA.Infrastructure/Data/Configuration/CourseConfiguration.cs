﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NASA_for_beginners.Infrastructure.Data.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(CreateHouses());
        }

        private List<Course> CreateHouses()
        {
            var courses = new List<Course>()
            {
                new Course()
                 {
                      Id = 1,
                      Title = "Phycis for Beginners",
                      Description = "Course 'Physics for Beginners' gives people basic understanding of physics needed for further specialization in NASAcademy.The course includes" +
                      "'Laws of Motion','Energy','Electromagnetism','Inside the Atom','Waves' and many more",
                      PricePerCourse = 100.00M,
                      CategoryId = 3,
                      TeacherId = 1,
                      StudentId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                 },

                new Course()
                {
                    Id = 2,
                    Title = "Math for Beginners",

                    Description = "Course 'Math for Beginners' gives people basic understanding of math needed for further specialization in NASAcademy.The course includes" +
                      "'Rational Numbers','IRational Numbers','Real Numbers','Prime Numbers','Composite Numbers' and many more",

                    PricePerCourse = 100.00M,
                    CategoryId = 3,
                    TeacherId = 1
                },

                new Course()
                {
                    Id = 3,
                    Title = "Biology for Beginners",

                    Description = "Course 'Biology for Beginners' gives people basic understanding of biology needed for further specialization in NASAcademy.The course includes" +
                      "'Life','Cells','Evolution','Genes','Homeostasis' and many more",

                    PricePerCourse = 100.00M,
                    CategoryId = 3,
                    TeacherId = 1
                },

                 new Course()
                {
                    Id = 4,
                    Title = "Engineering Introduction",

                    Description = "'Engineering Introduction' provides basic understanding of " +
                      "'Mechatronics','Electronics','Robot Systems','Software Engineering','Chemical and Biotechnoly Engineering' and many more",

                    PricePerCourse = 450.00M,
                    CategoryId = 2,
                    TeacherId = 1
                },
                  new Course()
                {
                    Id = 5,
                    Title = "Aviation Introduction",

                    Description = "'Aviation Introduction' provides basic understanding of " +
                      "'Principles of Flight','Airframe and Systems','Airline Operations','Air Traffic Services','Airline & Airport Marketing Management' and many more",

                    PricePerCourse = 450.00M,
                    CategoryId = 2,
                    TeacherId = 1
                }
                  ,
                  new Course()
                {
                    Id = 6,
                    Title = "Practise with Air-crafts",

                    Description = "'Practise with Air-crafts' physical trainning and understanding of the air-craft model " ,
                     

                    PricePerCourse = 1000.00M,
                    CategoryId = 3,
                    TeacherId = 1
                }
            };

            return courses;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NASA.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Beginner"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Fundamentals"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Advanced"
                }

             };

            return categories;
        }
    }
}

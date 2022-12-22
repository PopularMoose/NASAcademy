using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NASA.Core.Contracts;
using NASA.Core.Exceptions;
using NASA.Core.Models.Course;
using NASA.Core.Services;
using NASA.Infrastructure.Data;
using NASA.Infrastructure.Data.Common;

namespace NASA.Unit.Tests
{
    [TestFixture]
    public class CourseServiceTests
    {
        private IRepository repo;
        private ILogger<CoursesService> logger;
        private IGuard guard;
        private ICourseService courseService;
        private ApplicationDbContext applicationDbContext;


        [SetUp]
        public void Setup()
        {
            guard = new Guard();
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("NasaDb")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();

        }

        [Test]
        public async Task TestCourseEdit()
        {
            var loggerMock = new Mock<ILogger<CoursesService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);
            courseService = new CoursesService(repo, guard, logger);

            await repo.AddAsync(new Course() 
            { 
                Id = 1, 
                ImageUrl = "", 
                Title = "",
                Description = ""
            });

            await repo.SaveChangesAsync();

            await courseService.Edit(1, new CourseModel()
            {
                Id = 1,
                Title = "",
                ImageUrl = "",
                Description = "This house is edited"
            });

            var dbcourse = await repo.GetByIdAsync<Course>(1);

            Assert.That(dbcourse.Description, Is.EqualTo("This house is edited"));

        }


        [Test]
        public async Task TestLast3CoursesInMemory()
        {
            var loggerMock = new Mock<ILogger<CoursesService>>();
            logger = loggerMock.Object;

            var repo = new Repository(applicationDbContext);
            courseService = new CoursesService(repo, guard, logger);



            await repo.AddRangeAsync(new List<Course>()
            {
                 new Course() { Id = 1, ImageUrl = "", Title = "", Description = ""},
                  new Course() { Id = 3, ImageUrl = "", Title = "",  Description = ""},
                   new Course() { Id = 5, ImageUrl = "", Title = "", Description = ""},
                    new Course() { Id = 2, ImageUrl = "", Title = "", Description = ""}
            });

            await repo.SaveChangesAsync();
            var courseCollection = await courseService.LastThreeCourses();

            Assert.That(3, Is.EqualTo(courseCollection.Count()));
            Assert.That(courseCollection.Any(h => h.Id == 1), Is.False);
        }

        [Test]
        public async Task TestLast3CoursesNumberAndOrder()
        {
            var loggerMock = new Mock<ILogger<CoursesService>>();
            logger = loggerMock.Object;
            var repoMock = new Mock<IRepository>();
            IQueryable<Course> courses = new List<Course>()
            {
                 new Course() { Id = 1},
                  new Course() { Id = 3},
                   new Course() { Id = 5},
                    new Course() { Id = 2}
            }.AsQueryable();
            repoMock.Setup(r => r.AllReadonly<Course>())
                .Returns(courses);
            repo = repoMock.Object;

            courseService = new CoursesService(repo, guard, logger);


            var courseCollection = await courseService.LastThreeCourses();

            Assert.That(3, Is.EqualTo(courseCollection.Count()));
            Assert.That(courseCollection.Any(h => h.Id == 1), Is.False);
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NASA.Core.Contracts;
using NASA.Infrastructure.Data;
using NASA.Infrastructure.Data.Common;

namespace NASA.Core.Services
{
    public class TeacherService : ITeacher
    {
        private readonly IRepository repo;

        public TeacherService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId, string phoneNumber, string emailaddress, string name)
        {
            var teacher = new Teacher()
            {
                UserId = userId,
                Email = emailaddress,
                Name = name,
                PhoneNumber = phoneNumber
            };

            await repo.AddAsync(teacher);
            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Teacher>()
                .AnyAsync(a => a.UserId == userId);
        }

        public async Task<int> GetTeacherId(string userId)
        {
            return (await repo.AllReadonly<Teacher>()
                .FirstOrDefaultAsync(a => a.UserId == userId))?.Id ?? 0;
        }

       

        public async Task<bool> TeacherHasCourses(string userId)
        {
            return await repo.All<Course>()
                .AnyAsync(h => h.StudentId == userId);
        }

        public async Task<bool> TeacherWithEmailExists(string emailaddress)
        {
            return await repo.All<Teacher>()
                .AnyAsync(a => a.Email == emailaddress);
        }

        public async Task<bool> TeacherWithNameExists(string name)
        {
            return await repo.All<Teacher>()
                .AnyAsync(a => a.Name == name);
        }

        public async Task<bool> TeacherWithPhoneNumberExists(string phoneNumber)
        {
            return await repo.All<Teacher>()
                .AnyAsync(a => a.PhoneNumber == phoneNumber);
        }
    }
}

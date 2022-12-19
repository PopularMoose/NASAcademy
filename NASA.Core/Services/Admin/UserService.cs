using Microsoft.EntityFrameworkCore;
using NASA.Core.Contracts.Admin;
using NASA.Core.Models.Admin;
using NASA.Infrastructure.Data;
using NASA.Infrastructure.Data.Common;

namespace NASA.Core.Services.Admin
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
           repo = _repo;
        }

        public async Task<IEnumerable<UserServiceModel>> All()
        {
            List<UserServiceModel> result;

            result = await repo.AllReadonly<Teacher>().
                Select(a => new UserServiceModel()
                {
                    UserId = a.UserId,
                    Email = a.Email,
                    FullName = $"{ a.User.FirstName} {a.User.LastName}",
                    PhoneNumber = a.PhoneNumber
                })
                .ToListAsync();

            string[] teacherIds = result.Select(a => a.UserId).ToArray();

            result.AddRange(await repo.AllReadonly<ApplicationUser>()
                .Where(u => teacherIds.Contains(u.Id)== false)
                .Select(u => new UserServiceModel()
                {
                    UserId = u.Id,
                    Email = u.Email,
                    FullName = $"{ u.FirstName } { u.LastName }"
                })
                .ToListAsync());

            return result;
        }

        public async Task<string> UserFullName(string userId)
        {
            var user = await repo.GetByIdAsync<ApplicationUser>(userId);

            return $"{user?.FirstName} {user?.LastName}".Trim();
        }
    }
}

using Microsoft.AspNetCore.Identity;
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
       private readonly UserManager<ApplicationUser> userManager;
        public UserService(IRepository _repo, UserManager<ApplicationUser> _userManager)
        {
           repo = _repo;
            userManager = _userManager;
        }

        public async Task<IEnumerable<UserServiceModel>> All()
        {
            List<UserServiceModel> result;

            result = await repo.AllReadonly<Teacher>()
              
                .Select(a => new UserServiceModel()
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

        public async Task<bool> Forget(string userId)
        {
            
            var user = await userManager.FindByIdAsync(userId);

            user.PhoneNumber = null;
            user.FirstName = null;
            user.Email = null;
            user.IsActive = false;
            user.LastName = null;
            user.NormalizedEmail = null;
            user.UserName = $"forgottenUser-{DateTime.Now.Ticks}";
            user.NormalizedUserName = null;
            user.PasswordHash = null;

            var result = await userManager.UpdateAsync(user);

            return result.Succeeded;
        }

        public async Task<string> UserFullName(string userId)
        {
            var user = await repo.GetByIdAsync<ApplicationUser>(userId);

            return $"{user?.FirstName} {user?.LastName}".Trim();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using NASA.Core.Models.Admin;
using NASA.Infrastructure.Data;

namespace NASA.Core.Contracts.Admin
{
    public interface IUserService
    {
        Task<string> UserFullName(string userId);

        Task<IEnumerable<UserServiceModel>> All();

        Task<bool> Forget( string userId);
    }
}

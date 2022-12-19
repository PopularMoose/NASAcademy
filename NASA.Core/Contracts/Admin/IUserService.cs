using NASA.Core.Models.Admin;

namespace NASA.Core.Contracts.Admin
{
    public interface IUserService
    {
        Task<string> UserFullName(string userId);

        Task<IEnumerable<UserServiceModel>> All();
    }
}

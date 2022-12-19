using NASA.Core.Contracts;
using NASA.Core.Exceptions;
using NASA.Core.Services;
using NASA.Core.Services.Admin;
using NASA.Infrastructure.Data.Common;
using NASA.Core.Contracts.Admin;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NASAServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICourseService, CoursesService>();
            services.AddScoped<ITeacher, TeacherService>();
            services.AddScoped<IGuard, Guard>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}

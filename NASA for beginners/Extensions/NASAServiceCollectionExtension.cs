using NASA.Core.Contracts;
using NASA.Core.Exceptions;
using NASA.Core.Services;
using NASA.Infrastructure.Data.Common;

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

            return services;
        }
    }
}

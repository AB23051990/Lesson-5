using HW3.DAL.Repository.DataBase;

namespace Timesheets
{
    public static class Extensions
    {
        public static IServiceCollection AddSqlRepositories(this IServiceCollection container)
        {
            container.AddSingleton<UserDbContext>();

            return container;
        }
    }
}
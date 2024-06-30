using Microsoft.EntityFrameworkCore;
using TodoList_v1_0.Data;

namespace TodoList_v1_0
{
    public class DatabaseUtility
    {
        public static async Task EnsureDbCreatedAsync(DbContextOptions<ApplicationDbContext> options)
        {
            // empty to avoid logging while inserting (otherwise will flood console)
            var factory = new LoggerFactory();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>(options)
                .UseLoggerFactory(factory);

            using var context = new ApplicationDbContext(builder.Options);
            // result is true if the database had to be created
            if (await context.Database.EnsureCreatedAsync())
            {
                Console.WriteLine("Database creation a success!");
            }
        }
    }
}

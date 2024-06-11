using AspNetCoreIdentity.API.Database;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.API.Extentions;

public static class MigrationExtensions
{
    public static void AddMigrations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        using var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        dbContext.Database.Migrate();
    }
}

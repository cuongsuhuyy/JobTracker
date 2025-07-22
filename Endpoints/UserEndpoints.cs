using System.Xml.Serialization;
using JobTracker.Data;
using JobTracker.Models;
using Microsoft.EntityFrameworkCore;

public static class UserEndpoints
{
    public static RouteGroupBuilder MapUserEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/users").WithTags("Users");

        group.MapPost("/", async (User user, AppDbContext db) =>
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return Results.Created($"/api/users/{user.Id}", user);
        });

        group.MapGet("/", async (AppDbContext db) =>
        {
            var users = await db.Users.ToListAsync();
            return Results.Ok(users);
        });

        group.MapGet("/{id:int}", async (int id, AppDbContext db) =>
        {
            var user = await db.Users.FindAsync(id);
            return user is not null ? Results.Ok(user) : Results.NotFound();
        });

        return group;
    }
}

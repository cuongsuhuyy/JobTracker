using Microsoft.EntityFrameworkCore;
using JobTracker.Data;
using JobTracker.Models;

public static class JobEndpoints
{
    public static void MapJobEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/jobs").WithTags("Jobs");

        // GET all jobs
        group.MapGet("/", async (AppDbContext db) =>
        {
            var jobs = await db.JobApplications.ToListAsync();
            return Results.Ok(jobs);
        });

        // GET job by ID
        group.MapGet("/{id}", async (int id, AppDbContext db) =>
        {
            var job = await db.JobApplications.FindAsync(id);
            return job is not null ? Results.Ok(job) : Results.NotFound();
        });

        // POST create job
        group.MapPost("/", async (JobApplication dto, AppDbContext db) =>
        {
            var job = new JobApplication
            {
                CompanyName = dto.CompanyName,
                Position = dto.Position,
                Status = dto.Status,
                Salary = dto.Salary,
                AppliedDate = dto.AppliedDate,
                ContactEmail = dto.ContactEmail,
                UserId = dto.UserId
            };

            db.JobApplications.Add(job);
            await db.SaveChangesAsync();

            return Results.Created($"/api/jobs/{job.Id}", job);
        });


        // PUT update job
        group.MapPut("/{id}", async (int id, JobApplication updatedJob, AppDbContext db) =>
        {
            var job = await db.JobApplications.FindAsync(id);
            if (job is null) return Results.NotFound();

            job.CompanyName = updatedJob.CompanyName;
            job.Position = updatedJob.Position;
            job.Status = updatedJob.Status;
            job.Salary = updatedJob.Salary;
            job.AppliedDate = updatedJob.AppliedDate;
            job.ContactEmail = updatedJob.ContactEmail;

            await db.SaveChangesAsync();
            return Results.Ok(job);
        });

        // DELETE job
        group.MapDelete("/{id}", async (int id, AppDbContext db) =>
        {
            var job = await db.JobApplications.FindAsync(id);
            if (job is null) return Results.NotFound();

            db.JobApplications.Remove(job);
            await db.SaveChangesAsync();
            return Results.Ok();
        });
    }
}

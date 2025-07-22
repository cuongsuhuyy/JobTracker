namespace JobTracker.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public List<JobApplication> JobApplications { get; set; } = new();
}

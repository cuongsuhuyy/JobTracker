namespace JobTracker.Models;

public class JobApplication
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public string Status { get; set; } = "Applied";
    public decimal? Salary { get; set; }
    public DateTime AppliedDate { get; set; } = DateTime.UtcNow;
    public string ContactEmail { get; set; }
    public int UserId { get; set; } // just the ID, not full User object
}


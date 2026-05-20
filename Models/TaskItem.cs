namespace MiAp.Models;

public class TaskItem
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; } = "todo"; // "todo", "in-progress", "done"
    public string Priority { get; set; } = "medium"; // "low", "medium", "high"
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}

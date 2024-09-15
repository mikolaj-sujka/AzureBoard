namespace AzureBoard.Domain.Entities;

public class WorkItem
{
    public int Id { get; set; }
    public string State { get; set; }
    public string Area { get; set; }
    public string IterationPath { get; set; }
    public uint Priority { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal Effort { get; set; }
    public string Activity { get; set; }
    public decimal RemainingWork { get; set; }
    public string Type { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public User Author { get; set; }
    public Guid AuthorId { get; set; }
}
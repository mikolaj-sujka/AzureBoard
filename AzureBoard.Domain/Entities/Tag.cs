namespace AzureBoard.Domain.Entities;

public class Tag
{
    public int Id { get; set; }
    public string Value { get; set; }
    public ICollection<WorkItem> WorkItems { get; set; }
    // public ICollection<WorkItemTag> WorkItemTags { get; set; } = new List<WorkItemTag>();
}
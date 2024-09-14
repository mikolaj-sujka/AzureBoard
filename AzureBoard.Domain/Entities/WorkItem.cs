using System.ComponentModel.DataAnnotations.Schema;

namespace AzureBoard.Domain.Entities;

public class WorkItem
{
    public int Id { get; set; }
    public string State { get; set; }
    public string Area { get; set; }
    [Column("Iteration_Path")]
    public string IterationPath { get; set; }
    public uint Priority { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal Effort { get; set; }
    public string Activity { get; set; }
    public decimal RemainingWork { get; set; }
    public string Type { get; set; }
}
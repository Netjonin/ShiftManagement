namespace Domain.Entities.Models;

public class Worker
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Position { get; set; }
    public int Age { get; set; }
    public Guid CompanyId { get; set; }
    public Shift? Shift { get; set; }
}

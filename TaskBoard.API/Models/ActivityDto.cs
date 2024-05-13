namespace TaskBoard.API.Models;

public class ActivityDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Time { get; set; }
    public string ValueBefore { get; set; } = string.Empty;
    public string ValueAfter { get; set; } = string.Empty;
    public int CardId { get; set; }
    public int ListId { get; set; }
}

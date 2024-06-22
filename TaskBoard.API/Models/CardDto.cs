namespace TaskBoard.API.Models;

public class CardDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public int ListId { get; set; }
    public int BoardId { get; set; }

    public ICollection<ActivityDto> Activities { get; set; }
        = new List<ActivityDto>();
}
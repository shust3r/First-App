namespace TaskBoard.API.Models;

public class CardDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedOrModifiedDate { get; set; } //Rename into DueDate
    public Priority Priority { get; set; }
    public int ListId { get; set; }
}

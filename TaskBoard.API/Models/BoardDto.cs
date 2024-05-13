namespace TaskBoard.API.Models;

public class BoardDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<ListDto> Lists { get; set; }
        = new List<ListDto>();
}

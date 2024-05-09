namespace TaskBoard.API.Models;

public class ListDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int NumberOfCards
    {
        get { return CardList.Count; }
    }

    public ICollection<CardDto> CardList { get; set; }
        = new List<CardDto>();
}

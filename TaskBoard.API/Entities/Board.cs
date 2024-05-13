using System.ComponentModel.DataAnnotations;

namespace TaskBoard.API.Entities;

public class Board
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public ICollection<List> Lists { get; set; }
        = new List<List>();

    public Board(string name)
    {
        Name = name;
    }
}

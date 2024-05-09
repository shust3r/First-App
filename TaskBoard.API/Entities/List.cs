using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskBoard.API.Entities;

public class List
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public ICollection<Card> Cards { get; set; }
        = new List<Card>();

    public List(string name)
    {
        Name = name;
    }
}
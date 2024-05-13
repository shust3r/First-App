using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskBoard.API.Entities;

public class Card
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(400)]
    public string Description { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    public int Priority { get; set; }

    [ForeignKey("ListId")]
    public int ListId { get; set; }

    public ICollection<Activity> Activities { get; set; }
        = new List<Activity>();

    public Card(string name, string description)
    {
        Name = name;
        Description = description;
    }
}

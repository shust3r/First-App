using System.ComponentModel.DataAnnotations;

namespace TaskBoard.API.Models;

public class CardForUpdateDto
{
    [Required(ErrorMessage = "The name should not be empty")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(400)]
    public string? Description { get; set; }

    public Priority Priority { get; set; }

    public int ListId { get; set; }
}

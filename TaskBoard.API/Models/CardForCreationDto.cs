using System.ComponentModel.DataAnnotations;

namespace TaskBoard.API.Models;

public class CardForCreationDto
{
    [Required(ErrorMessage = "The name should not be empty")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(400)]
    public string? Description { get; set; }

    [Required]
    public Priority Priority { get; set; }

    public DateTime? DueDate { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace TaskBoard.API.Models;

public class BoardForUpdateDto
{
    [Required(ErrorMessage = "The name should not be empty")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
}

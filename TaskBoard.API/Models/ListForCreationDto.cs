using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskBoard.API.Models;

public class ListForCreationDto
{
    [Required(ErrorMessage = "The name should not be empty")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [ForeignKey("BoardId")]
    public int BoardId { get; set; }
}

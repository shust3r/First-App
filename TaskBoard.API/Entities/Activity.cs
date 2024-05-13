using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskBoard.API.Entities;

public class Activity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string OperationName { get; set; }

    [Required]
    public DateTime OperationDate { get; set; }

    public string ValueBefore { get; set; }
    
    public string ValueAfter { get; set; }

    public int ListId { get; set; }

    [ForeignKey("CardId")]
    public int CardId { get; set; }

    public Activity(string OperationName, string ValueBefore, string ValueAfter)
    {
        this.OperationName = OperationName;
        this.ValueBefore = ValueBefore;
        this.ValueAfter = ValueAfter;
    }
}

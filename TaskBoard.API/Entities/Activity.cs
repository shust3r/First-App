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

    [ForeignKey("ListId")]
    public int ListId { get; set; }

    public string ListName { get; set; }

    [ForeignKey("CardId")]
    public int CardId { get; set; }

    [ForeignKey("BoardId")]
    public int BoardId { get; set; }
    
    public string CardName { get; set; }

    public Activity(string OperationName, string ValueBefore, string ValueAfter, string ListName, string CardName)
    {
        this.OperationName = OperationName;
        this.ValueBefore = ValueBefore;
        this.ValueAfter = ValueAfter;
        this.ListName = ListName;
        this.CardName = CardName;
    }
}

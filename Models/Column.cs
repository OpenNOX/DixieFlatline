namespace DixieFlatline.Models;

using System.ComponentModel.DataAnnotations;
using DixieFlatline.Shared;

public class Column
{
    [Required]
    [StringLength(64, ErrorMessage = "Column name is too long.")]
    public string TableName { get; set; } = "";

    [Required]
    [StringLength(64, ErrorMessage = "Column name is too long.")]
    public string Name { get; set; } = "";

    [Required]
    public Generator Generator { get; set; }
}

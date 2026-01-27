using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }

    [MaxLength(200)]
    public string Name { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    [MaxLength(50)]
    public string UnitType { get; set; }
}

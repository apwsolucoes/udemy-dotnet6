using System.ComponentModel.DataAnnotations.Schema;

[Table("ProductTag")]
public class ProductTag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProductId { get; set; }
}
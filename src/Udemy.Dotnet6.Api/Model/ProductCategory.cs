using System.ComponentModel.DataAnnotations.Schema;

[Table("ProductCategory")]
public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
}
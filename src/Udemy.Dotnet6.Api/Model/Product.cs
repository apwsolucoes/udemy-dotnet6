using System.ComponentModel.DataAnnotations.Schema;

[Table("Product")]
public class Product
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public ProductCategory Category { get; set; }
    public List<ProductTag> Tags { get; set; }
}
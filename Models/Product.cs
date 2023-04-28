namespace NestStart.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal Rating { get; set; }
    public bool IsDeleted { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<ProductImage> ProductImages { get; set; }
}

using NestStart.Models;

namespace NestStart.ViewModel;

public class HomeVM
{
    public List<Slider> Sliders { get; set; }
    public List<Category> Categories { get; set; }
    public List<Product> Products { get; set; }
    public List<ProductImage> ProductImages { get; set; }
}

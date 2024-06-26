using CodeFirstDemo.Models;

namespace CodeFirstDemo.ResponseModels;

public class PostProductResponseModel
{
    public string productName { get; set; }
    public decimal productWeight { get; set; }
    public decimal productWidth { get; set; }
    public decimal productHeight { get; set; }
    public decimal productDepth { get; set; }
    public List<int> productCategories;

    public PostProductResponseModel(Product product)
    {
        productName = product.Name;
        productWeight = product.Weight;
        productWidth = product.Width;
        productHeight = product.Height;
        productDepth = product.Depth;
        productCategories = new List<int>();
        foreach (var category in product.Categories)
        {
            productCategories.Add(category.CategoryId);
        }
    }
}
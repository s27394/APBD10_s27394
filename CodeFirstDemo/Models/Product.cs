using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeFirstDemo.RequestModels;

namespace CodeFirstDemo.Models;


[Table("Products")]
public class Product
{
    public Product(PostProductRequestModel request)
    {
        Name = request.Name;
        Weight = request.Weight;
        Width = request.Width;
        Height = request.Height;
        Depth = request.Depth;
        Categories = new List<ProductCategory>();
    }
    public Product() { }


    [Key]
    [Column("PK_product")]
    public int PK { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("weight", TypeName = "decimal(5,2)")]
    public decimal Weight { get; set; }

    [Column("width", TypeName = "decimal(5,2)")]
    public decimal Width { get; set; }

    [Column("height", TypeName = "decimal(5,2)")]
    public decimal Height { get; set; }

    [Column("depth", TypeName = "decimal(5,2)")]
    public decimal Depth { get; set; }
    public List<ProductCategory> Categories { get; set; }
}
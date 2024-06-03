using CodeFirstDemo.Models;

namespace CodeFirstDemo.ResponseModels;

public class GetAccountResponseModel
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string? phone { get; set; }
    public String role { get; set; }
    public IEnumerable<CartResponseModel> cart { get; set; }
}
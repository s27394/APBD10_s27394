using CodeFirstDemo.RequestModels;
using CodeFirstDemo.ResponseModels;

namespace CodeFirstDemo.Interfaces;

public interface IDbService
{
    Task<GetAccountResponseModel> GetAccountByIdAsync(int id);
    // Task<PostProductResponseModel> AddProductWithCategories(PostProductRequestModel request);

}
using CodeFirstDemo.Contexts;
using CodeFirstDemo.Interfaces;
using CodeFirstDemo.RequestModels;
using CodeFirstDemo.ResponseModels;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Services;

public class DbService(DatabaseContext context) : IDbService
{
    public async Task<GetAccountResponseModel> GetAccountByIdAsync(int id)
    {
        var response = await context.Accounts
            .Where(a => a.AccountId == id)
            .Select(a => new GetAccountResponseModel
            {
                firstName = a.AccountFirstName,
                lastName = a.AccountLastName,
                email = a.AccountEmail,
                phone = a.AccountPhone,
                role = a.Role.RoleName,
                cart = context.ShoppingCarts
                    .Where(sc => sc.AccountID == id)
                    .Select(sc => new CartResponseModel
                    {
                        ProductId = sc.ProductID,
                        ProductName = sc.Product.Name,
                        Amount = sc.ShoppingCartAmount
                    }).ToList()
            }).FirstOrDefaultAsync();

        if (response is null)
        {
            throw new Exception($"Account with id:{id} does not exist.");
        }

        return response;
    }

}
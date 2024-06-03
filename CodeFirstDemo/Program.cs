using CodeFirstDemo.Contexts;
using CodeFirstDemo.Exceptions;
using CodeFirstDemo.Interfaces;
using CodeFirstDemo.RequestModels;
using CodeFirstDemo.Services;
using CodeFirstDemo.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddDbContext<DatabaseContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<PostProductRequestModelValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/accounts/{id:int}", async (int id, IDbService service) =>
{
    try
    {
        return Results.Ok(await service.GetAccountByIdAsync(id));
    }
    catch (NotFoundException e)
    {
        return Results.NotFound(e.Message);
    }
});

app.MapPost("api/products", async (PostProductRequestModel requestModel, IDbService service, IValidator<PostProductRequestModel> validator) =>
{
    var validationResult = await validator.ValidateAsync(requestModel);
    if (!validationResult.IsValid)
    {
        return Results.BadRequest(validationResult.Errors);
    }

    try
    {
        var result = await service.AddProductWithCategories(requestModel);
        return Results.Created($"product created" , result);
    }
    catch (AddProductException e)
    {
        return Results.BadRequest(e.Message);
    }
});

app.Run();
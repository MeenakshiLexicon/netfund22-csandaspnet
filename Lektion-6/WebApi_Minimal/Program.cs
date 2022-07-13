using Microsoft.AspNetCore.Mvc;
using WebApi_Minimal.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


List<User> _users = new List<User>();
List<Product> _products = new List<Product>();

app.MapGet("/api/users", () => 
{
    return _users; 
}).WithName("GetAllUsers");

app.MapGet("/api/users/{id}", (int id) =>
{
    var _user = _users.FirstOrDefault(x => x.Id == id);
    return _user;
}).WithName("GetUser");

app.MapPost("/api/users", (User user) =>
{
    _users.Add(user);
    return new CreatedResult("https://localhost/", user);
}).WithName("CreateUser");

app.MapGet("/api/products", () =>
{
    return _products;
}).WithName("GetAllProducts");

app.MapGet("/api/products/{id}", (int id) =>
{
    var _product = _products.FirstOrDefault(x => x.Id == id);
    return _product;
}).WithName("GetProduct");


app.Run();

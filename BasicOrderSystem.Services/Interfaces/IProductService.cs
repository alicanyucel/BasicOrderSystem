﻿// BasicOrderSystem.Services/Interfaces/IProductService.cs
using BasicOrderSystem.Domain.Entities;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product> GetProductByIdAsync(int id);
    Task CreateProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
}

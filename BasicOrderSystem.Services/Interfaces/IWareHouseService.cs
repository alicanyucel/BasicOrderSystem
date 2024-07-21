// BasicOrderSystem.Services/Interfaces/IWarehouseService.cs
using BasicOrderSystem.Domain.Entities;

public interface IWarehouseService
{
    Task<IEnumerable<Warehouse>> GetAllWarehousesAsync();
    Task<Warehouse> GetWarehouseByIdAsync(int id);
    Task CreateWarehouseAsync(Warehouse warehouse);
    Task UpdateWarehouseAsync(Warehouse warehouse);
    Task DeleteWarehouseAsync(int id);
}

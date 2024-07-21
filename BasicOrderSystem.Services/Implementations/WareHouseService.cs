// BasicOrderSystem.Services/Implementations/WarehouseService.cs
using BasicOrderSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class WarehouseService : IWarehouseService
{
    private readonly ApplicationDbContext _context;

    public WarehouseService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Warehouse>> GetAllWarehousesAsync()
    {
        return await _context.Warehouses.ToListAsync();
    }

    public async Task<Warehouse> GetWarehouseByIdAsync(int id)
    {
        return await _context.Warehouses.FindAsync(id);
    }

    public async Task CreateWarehouseAsync(Warehouse warehouse)
    {
        _context.Warehouses.Add(warehouse);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateWarehouseAsync(Warehouse warehouse)
    {
        _context.Entry(warehouse).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteWarehouseAsync(int id)
    {
        var warehouse = await _context.Warehouses.FindAsync(id);
        if (warehouse != null)
        {
            warehouse.IsDeleted = true;
            await _context.SaveChangesAsync();
        }
    }
}

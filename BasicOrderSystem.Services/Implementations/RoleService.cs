// BasicOrderSystem.Services/Implementations/RoleService.cs
using BasicOrderSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class RoleService : IRoleService
{
    private readonly ApplicationDbContext _context;

    public RoleService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Role>> GetAllRolesAsync()
    {
        return await _context.Roles.ToListAsync();
    }

    public async Task<Role> GetRoleByIdAsync(int id)
    {
        return await _context.Roles.FindAsync(id);
    }

    public async Task CreateRoleAsync(Role role)
    {
        _context.Roles.Add(role);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRoleAsync(Role role)
    {
        _context.Entry(role).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRoleAsync(int id)
    {
        var role = await _context.Roles.FindAsync(id);
        if (role != null)
        {
            role.IsDeleted = true;
            await _context.SaveChangesAsync();
        }
    }
}
﻿// BasicOrderSystem.Services/Interfaces/IUserService.cs
using BasicOrderSystem.Domain.Entities;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<User> GetUserByIdAsync(int id);
    Task CreateUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(int id);
}
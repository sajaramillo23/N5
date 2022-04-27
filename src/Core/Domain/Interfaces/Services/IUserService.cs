using Microsoft.AspNetCore.Identity;
using N5.Domain.Dtos;
using N5.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace N5.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(UserDto userDto);
        Task<UserDto> GetUserAysnc(Guid userId);
        Task DeleteUserAysnc(UserDto user);
    }
}

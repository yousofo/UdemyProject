﻿using Udemy.Core.ReadOptions;
using Udemy.Service.DataTransferObjects.UserDTOs;

namespace Udemy.Service.IService;
public interface IUserService
{
    Task<UserDto> CreateUserAsync(UserForCreationDto userDto);
    Task DeleteUserAsync(int id);
    Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges , RequestParamter? requestParamter);
    Task<UserDto> GetUserByEmailAsync(string email);
    Task<UserDto> GetUserByIdAsync(int id);
    Task<UserDto> GetUserByUsernameAsync(string username);
    Task UpdateUserAsync(int id , UserForUpdatingDto userDto);
}

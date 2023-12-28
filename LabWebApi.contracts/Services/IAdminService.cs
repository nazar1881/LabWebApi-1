﻿using LabWebApi.contracts.DTO.AdminPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<UserInfoDTO>> GetUsersAsync();
        Task<UserInfoDTO> GetUserByIdAsync(string id);
        Task<UserInfoDTO> EditUserAsync(UserInfoDTO userDTO);
        Task DeleteUserAsync(string id);
    }
}

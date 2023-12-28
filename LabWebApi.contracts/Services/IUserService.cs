using LabWebApi.contracts.ApiModels;
using LabWebApi.contracts.DTO.AdminPanel;
using LabWebApi.contracts.DTO.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Services
{
    public interface IUserService
    {
        Task<UserInfoDTO> GetProfileAsync(string id);
        Task UploadAvatar(IFormFile avatar, string userId);
        Task<DownloadFile> GetUserImageAsync(string userId);
        Task EditUserProfileAsync(ProfileInfoDTO model, string id);
        Task ChangePasswordProfileAsync(ChangePasswordDTO changePasswordDTO, string userId);
        Task DeleteProfileAsync(string userId);
    }
}

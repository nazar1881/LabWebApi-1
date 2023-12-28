using AutoMapper;
using LabWebApi.contracts.Data.Entities;
using LabWebApi.contracts.DTO.AdminPanel;
using LabWebApi.contracts.DTO.Authentications;

namespace LabWevApi.Services.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<UserRegistrationDTO, User>();
            CreateMap<UserInfoDTO, User>();
            CreateMap<User, UserInfoDTO>();
        }
    }
}
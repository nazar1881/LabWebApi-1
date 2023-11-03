using AutoMapper;
using LabWebApi.contracts.DTO.Authentications;
using LabWebAPI.Contracts.Data.Entities;
namespace LabWebAPI.Services.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<UserRegistrationDTO, User>();
        }
    }
}
using AutoMapper;
using LabWebApi.contracts.Data.Entities;
using LabWebApi.contracts.DTO.AdminPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.Services.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ProfileInfoDTO, User>();
        }
    }
}

using AutoMapper;
using LabWebApi.contracts.Data.Entities;
using LabWebApi.contracts.DTO.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.Services.Mapper
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CreateCommentDTO, Comment>();
            CreateMap<Comment, CreateCommentDTO>();
            CreateMap<CommentDTO, Comment>();
            CreateMap<Comment, CommentDTO>();
        }
    }
}

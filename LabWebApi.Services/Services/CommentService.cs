using AutoMapper;
using LabWebApi.contracts.Data.Entities;
using LabWebApi.contracts.Data;
using LabWebApi.contracts.DTO.Comment;
using LabWebApi.contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.Services.Services
{
    public class CommentService : ICommentService
    {
        private protected readonly IMapper _mapper;
        private readonly IRepository<Comment> _commentRepository;
        public CommentService(IRepository<Comment> commentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
        }
        public async Task<IEnumerable<CommentDTO>> GetAllCommentsAsync(int productId)
        {

            var comments = _commentRepository.Query()
                .Where(x => x.ProductId == productId)
                .ToList();

            var commentDTOs = _mapper.Map<IEnumerable<CommentDTO>>(comments);
            return commentDTOs;
        }

        public async Task<CreateCommentDTO> AddCommentAsync(CreateCommentDTO comment)
        {
            var commentEntity = _mapper.Map<Comment>(comment);

            var result = await _commentRepository.AddAsync(commentEntity);
            await _commentRepository.SaveChangesAsync();

            var response = _mapper.Map<CreateCommentDTO>(result);
            return response;
        }
        public async Task DeleteCommentAsync(int commentId)
        {
            var comment = await _commentRepository.GetByIdAsync(commentId);
            if (comment != null)
            {
                await _commentRepository.DeleteAsync(comment);
                await _commentRepository.SaveChangesAsync();
            }
        }
    }
}

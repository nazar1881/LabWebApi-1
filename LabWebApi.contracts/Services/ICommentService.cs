using LabWebApi.contracts.DTO.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Services
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentDTO>> GetAllCommentsAsync(int productId);
        Task<CreateCommentDTO> AddCommentAsync(CreateCommentDTO comment);
        Task DeleteCommentAsync(int commentId);
    }
}

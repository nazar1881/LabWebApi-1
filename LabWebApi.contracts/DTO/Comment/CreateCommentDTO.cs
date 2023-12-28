using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.DTO.Comment
{
    public class CreateCommentDTO
    {
        public string Text { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }

    }
}

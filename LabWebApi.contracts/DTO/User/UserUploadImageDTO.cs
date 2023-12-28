using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.DTO.User
{
    public class UserUploadImageDTO
    {
        public IFormFile Image { get; set; }
    }
}

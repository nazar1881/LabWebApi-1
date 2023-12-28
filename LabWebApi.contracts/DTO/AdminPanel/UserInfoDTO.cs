using LabWebApi.contracts.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.DTO.AdminPanel
{
    public class UserInfoDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public AuthorizationRoles Role { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Exceptions
{
    public class UserAlreadyExistsException : BadRequestException
    {
        public UserAlreadyExistsException(string value) : base($"User with this {value} was already exists!") { }
    }
}

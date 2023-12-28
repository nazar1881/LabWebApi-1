using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Exceptions
{
    public class InvalidTokenException : BadRequestException
    {
        public InvalidTokenException() : base("Invalid Token") { }
    }
}

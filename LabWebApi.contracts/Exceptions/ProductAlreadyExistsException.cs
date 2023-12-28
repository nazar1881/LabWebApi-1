using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Exceptions
{
    public class ProductAlreadyExistsException : BadRequestException
    {
        public ProductAlreadyExistsException(string value) : base($"Product with this was already exists!") { }
    }
}

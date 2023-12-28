using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(string message) : base(message) { }
    }
}

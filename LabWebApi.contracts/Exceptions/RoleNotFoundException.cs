﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Exceptions
{
    public class RoleNotFoundException : NotFoundException
    {
        public RoleNotFoundException() : base("System don't have this role!") { }
    }
}

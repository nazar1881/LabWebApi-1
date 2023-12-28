using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Services
{
    public interface ILocaleStorageService : IFileService, ICreateDirectory { }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.ApiModels
{
    public class DownloadFile : IDisposable
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public Stream Content { get; set; }
        public void Dispose()
        {
            if (Content != null)
            {
                Content.Dispose();
            }
        }
    }
}

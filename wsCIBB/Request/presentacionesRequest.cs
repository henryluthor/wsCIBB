using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wsCIBB.Request
{
    public class presentacionesRequest
    {
        public IFormFile ArchivoPresentacion { get; set; }
    }
}

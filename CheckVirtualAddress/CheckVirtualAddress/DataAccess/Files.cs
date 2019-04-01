using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckVirtualAddress.Models;

namespace CheckVirtualAddress.DataAccess
{
    public class Files
    {

        public VpaDetails[] GetVpaDetails()
        {
            return new ReadFiles<VpaDetails>().Get(@"/Response.json");
        }

    }
}

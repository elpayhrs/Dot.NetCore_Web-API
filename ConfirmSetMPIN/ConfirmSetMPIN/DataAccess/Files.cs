using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfirmSetMPIN.Models;

namespace ConfirmSetMPIN.DataAccess
{
    public class Files
    {

        public RequestInfo[] Getcsmp()
        {
            return new ReadFiles<RequestInfo>().Get(@"/Response.Json");
        }

    }
}

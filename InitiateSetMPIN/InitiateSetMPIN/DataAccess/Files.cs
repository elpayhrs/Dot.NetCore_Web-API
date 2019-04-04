using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InitiateSetMPIN.Models;

namespace InitiateSetMPIN.DataAccess
{
    public class Files
    {

        public Cred[] Getcred()
        {
            // return new ReadFiles<Cred>().Get(@"/Response.json");// linux
            return new ReadFiles<Cred>().Get(@"\Response.json");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetBankList.Models;

namespace GetBankList.DataAccess
{
    public class Files
    {

        public Bank[] GetBanks()
        {

            return new ReadFiles<Bank>().Get(@"\Response.json");
            // return new Bank[] { };
        }

    }
}

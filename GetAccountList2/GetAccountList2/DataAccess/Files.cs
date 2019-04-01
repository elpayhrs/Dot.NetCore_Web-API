using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetAccountList2.Models;

namespace GetAccountList2.DataAccess
{
    public class Files
    {

        public AccountList[] Account2()
        {
            return new ReadFiles<AccountList>().Get(@"/Response.Json");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetAccountList.Models;

namespace GetAccountList.DataAccess
{
    public class Files
    {
        public AccountList[] GetAccounts()
        {
            return new ReadFiles<AccountList>().Get(@"/Response.Json");
        }
    }
}

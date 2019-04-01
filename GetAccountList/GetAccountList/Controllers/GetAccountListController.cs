using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GetAccountList.DataAccess;
using GetAccountList.Models;


namespace GetAccountList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAccountListController : ControllerBase
    {

        [HttpPost]
        public GetAccountListResponse Post([FromBody] GetAccountListRequest value)
        {

            var responseobject = new GetAccountListResponse() { status = "S", AccountMasterLists = new Files().GetAccounts() };
            // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using GetAccountList2.DataAccess;
using GetAccountList2.Models;

namespace GetAccountList2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAccountList2Controller : ControllerBase
    {

        [HttpPost]
        public GetAccountList2Response Post([FromBody] GetAccountList2Request value)
        {

            var responseobject = new GetAccountList2Response() { status = "S", AccountMasterList = new Files().Account2() };
            // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

    }
}
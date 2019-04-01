using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GetBankListReq.Models;
using System.Net.Http;
using GetBankListReq.DataAccess;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace GetBankListReq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetBankListReqController : ControllerBase
    {
        
        // POST api/values
        [HttpPost]
        public GetBankListResponse Post([FromBody] GetBankListReqJson value)
        {

            var responseobject = new GetBankListResponse() { Status = "S" , BankMasterList = new Files().GetBanks() };
           // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

        
    }
}

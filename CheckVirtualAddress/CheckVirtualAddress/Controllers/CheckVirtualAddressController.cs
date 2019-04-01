using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CheckVirtualAddress.Models;
using CheckVirtualAddress.DataAccess;

namespace CheckVirtualAddress.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckVirtualAddressController : ControllerBase
    {

        [HttpPost]
        public CheckvirtualAddressResponse Post([FromBody] CheckVirtualAddressRequest value)
        {

            var responseobject = new CheckvirtualAddressResponse() { status = "S", VpaDetailsMasterList = new Files().GetVpaDetails() };
            // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

    }
}
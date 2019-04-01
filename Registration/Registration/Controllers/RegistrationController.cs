using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using Registration.DataAccess;

namespace Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        [HttpPost]
        public RegistrationResponse Post([FromBody] RegistrationRequest value)
        {

            var responseobject = new RegistrationResponse() { status = "S", requMasterList = new Files().GetReg() };
            // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

    }
}
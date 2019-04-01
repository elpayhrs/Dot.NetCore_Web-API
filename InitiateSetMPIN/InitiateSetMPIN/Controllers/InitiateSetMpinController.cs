using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InitiateSetMPIN.Models;
using InitiateSetMPIN.DataAccess;

namespace InitiateSetMPIN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitiateSetMpinController : ControllerBase
    {

        [HttpPost]
        public InitiateSetMPINResponse Post([FromBody] InitiateSetMPINRequest value)
        {

            var responseobject = new InitiateSetMPINResponse() { status = "S", CredMasterList = new Files().Getcred() };
            // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

    }
}
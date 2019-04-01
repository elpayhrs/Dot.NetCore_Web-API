using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConfirmSetMPIN.DataAccess;
using ConfirmSetMPIN.Models;

namespace ConfirmSetMPIN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmSetMPINController : ControllerBase
    {

        [HttpPost]
        public ConfirmSetMPINResponse Post([FromBody] ConfirmSetMPINRequest value)
        {

            var responseobject = new ConfirmSetMPINResponse() { status = "S", RequestInfoList = new Files().Getcsmp() };
            // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

    }
}
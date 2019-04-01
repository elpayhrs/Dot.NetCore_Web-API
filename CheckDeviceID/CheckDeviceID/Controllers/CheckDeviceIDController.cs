using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CheckDeviceID.Models;
using CheckDeviceID.DataAccess;

namespace CheckDeviceID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckDeviceIDController : ControllerBase
    {

        [HttpPost]
        public checkdeviceidResponse Post([FromBody] checkdeviceidRequest value)
        {

            var responseobject = new checkdeviceidResponse() { status = "S", deviceMasterList = new Files().getDevice() };
            // GetBankListResponse response = new GetBankListResponse( );
            return responseobject;


        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckDeviceID.Models;

namespace CheckDeviceID.DataAccess
{
    public class Files
    {
        public DeviceInfores[] getDevice()
        {
            //return new ReadFile<Bank>().Get(@"\banks.json");
            return new ReadFiles<DeviceInfores>().Get(@"\Response.json");
           // return new ReadFiles<DeviceInfores>().Get(@"/Response.json"); //linux
        }
    }
}

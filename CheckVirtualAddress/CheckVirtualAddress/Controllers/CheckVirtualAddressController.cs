using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CheckVirtualAddress.Models;
using CheckVirtualAddress.DataAccess;
using System.Data;
using System.Data.SqlClient;


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


            checkvirtualaddress data = new checkvirtualaddress();


            data.addInfo10 = value.Addinfo.addInfo10;
            data.addInfo9 = value.Addinfo.addInfo9;


            data.datestamp = DateTime.Now;

            data.androidId = value.Deviceinfo.androidid;
            data.appName = value.Deviceinfo.appName;
            data.appVersionCode = value.Deviceinfo.appVersionCode;
            data.appVersionName = value.Deviceinfo.appVersionName;
            data.bluetoothMac = value.Deviceinfo.bluetoothMac;
            data.capability = value.Deviceinfo.capability;
            data.deviceId = value.Deviceinfo.deviceId;
            data.deviceType = value.Deviceinfo.deviceType;
            data.geoCode = value.Deviceinfo.geoCode;
            data.ip = value.Deviceinfo.ip;
            data.location = value.Deviceinfo.location;
            data.mobileNo = value.Deviceinfo.mobileNo;
            data.os = value.Deviceinfo.os;
            data.regId = value.Deviceinfo.regId;
            data.selectedSimSlot = value.Deviceinfo.selectedSimSlot;
            data.simId = value.Deviceinfo.simId;
            data.wifiMac = value.Deviceinfo.wifiMac;



            data.pspId = value.RequestInfo.pspId;
            data.pspRefNo = value.RequestInfo.pspRefNo;
            data.profileId = value.RequestInfo.profileId;

            data.virtualAddress = value.Payeetype.virtualAddress;


            data.request = "POST";

            data.apiname = ControllerContext.RouteData.Values["controller"].ToString();


            string strcon = "Server=DESKTOP-N5AIHVF\\SRSSQL;Database=WEBAPI;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into checkvirtualaddress ( data.datestamp , data.apiname, data.request, data.androidId, data.appName, data.appVersionCode, data.appVersionName, data.bluetoothMac, data.capability, data.deviceId, data.deviceType, data.geoCode, data.ip, data.location, data.mobileNo, data.os, data.regId, data.selectedSimSlot, data.simId, data.wifiMac, data.pspId, data.pspRefNo, data.profileId , data.addInfo10, data.addInfo9,data.virtualAddress) values('" + data.datestamp + "', '" + data.apiname + "', '" + data.request + "','" + data.androidId + "', '" + data.appName + "', '" + data.appVersionCode + "', '" + data.appVersionName + "', '" + data.bluetoothMac + "', '" + data.capability + "', '" + data.deviceId + "', '" + data.deviceType + "', '" + data.geoCode + "', '" + data.ip + "', '" + data.location + "', '" + data.mobileNo + "', '" + data.os + "', '" + data.regId + "', '" + data.selectedSimSlot + "', '" + data.simId + "', '" + data.wifiMac + "', '" + data.pspId + "', '" + data.pspRefNo + "', '" + data.profileId + "', '" + data.addInfo10 + "', '" + data.addInfo9 + "','" + data.virtualAddress + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();



            return responseobject;


        }

    }
}
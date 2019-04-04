using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using Registration.DataAccess;
using System.Data;
using System.Data.SqlClient;

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


            registrationdb data = new registrationdb();



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
            data.wifiMac = value.Deviceinfo.WifiMac;



            data.pspId = value.RequestInfo.pspId;
            data.pspRefNo = value.RequestInfo.pspRefNo;
            data.profileId = value.RequestInfo.profileId;

            data.altMobNo = value.userInfo.altMobNo;
            data.name = value.userInfo.name;
            data.email = value.userInfo.email;
            data.quesId = value.userInfo.secretDetails.quesId;

            data.accountId = value.accountId;
            data.virtualAddress = value.virtualAddress;

            data.secretAnswer = value.userInfo.secretDetails.secretAnswer;



            data.request = "POST";

            data.apiname = ControllerContext.RouteData.Values["controller"].ToString();


            string strcon = "Server=DESKTOP-N5AIHVF\\SRSSQL;Database=WEBAPI;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into registrationdb ( data.datestamp , data.apiname, data.request, data.androidId, data.appName, data.appVersionCode, data.appVersionName, data.bluetoothMac, data.capability, data.deviceId, data.deviceType, data.geoCode, data.ip, data.location, data.mobileNo, data.os, data.regId, data.selectedSimSlot, data.simId, data.wifiMac, data.pspId, data.pspRefNo, data.profileId , data.altMobNo,data.email,data.name,data.secretAnswer,data.quesId,data.accountId,data.virtualAddress) values('" + data.datestamp + "', '" + data.apiname + "', '" + data.request + "','" + data.androidId + "', '" + data.appName + "', '" + data.appVersionCode + "', '" + data.appVersionName + "', '" + data.bluetoothMac + "', '" + data.capability + "', '" + data.deviceId + "', '" + data.deviceType + "', '" + data.geoCode + "', '" + data.ip + "', '" + data.location + "', '" + data.mobileNo + "', '" + data.os + "', '" + data.regId + "', '" + data.selectedSimSlot + "', '" + data.simId + "', '" + data.wifiMac + "', '" + data.pspId + "', '" + data.pspRefNo + "', '" + data.profileId + "','" + data.altMobNo + "','" + data.email + "','" + data.name + "','" + data.secretAnswer + "','" + data.quesId + "','" + data.accountId + "','" + data.virtualAddress + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();




            return responseobject;


        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using GetAccountList2.DataAccess;
using GetAccountList2.Models;
using System.Data;
using System.Data.SqlClient;

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


            getaccountlist2 data = new getaccountlist2();


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
            data.recoveryOptionFlag = value.Deviceinfo.recoveryOptionFlag;

            
            data.pspId = value.Requestinfo.pspId;
            data.pspRefNo = value.Requestinfo.pspRefNo;
            data.profileId = value.Requestinfo.profileId;
            data.requestType = value.Requestinfo.requestType;
            data.updateFlag = value.Requestinfo.updateFlag;

            data.defVPAStatus = value.Userinfo.defVPAStatus;
            data.name = value.Userinfo.name;
            data.accountId = value.Userinfo.accountId;
            data.virtualAddress = value.Userinfo.virtualAddress;

            data.request = "POST";

            data.apiname = ControllerContext.RouteData.Values["controller"].ToString();


            string strcon = "Server=DESKTOP-N5AIHVF\\SRSSQL;Database=WEBAPI;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into getaccountlist2 ( data.datestamp , data.apiname, data.request, data.androidId, data.appName, data.appVersionCode, data.appVersionName, data.bluetoothMac, data.capability, data.deviceId, data.deviceType, data.geoCode, data.ip, data.location, data.mobileNo, data.os, data.regId, data.selectedSimSlot, data.simId, data.wifiMac,data.recoveryOptionFlag, data.pspId, data.pspRefNo, data.profileId, data.requestType, data.updateFlag, data.defVPAStatus, data.name, data.accountId, data.virtualAddress ,data.bankCode) values('" + data.datestamp + "', '" + data.apiname + "', '" + data.request + "','" + data.androidId + "', '" + data.appName + "', '" + data.appVersionCode + "', '" + data.appVersionName + "', '" + data.bluetoothMac + "', '" + data.capability + "', '" + data.deviceId + "', '" + data.deviceType + "', '" + data.geoCode + "', '" + data.ip + "', '" + data.location + "', '" + data.mobileNo + "', '" + data.os + "', '" + data.regId + "', '" + data.selectedSimSlot + "', '" + data.simId + "', '" + data.wifiMac + "','" + data.recoveryOptionFlag + "', '" + data.pspId + "', '" + data.pspRefNo + "', '" + data.profileId + "','" + data.requestType + "','" + data.updateFlag + "','" + data.defVPAStatus + "','" + data.name + "','" + data.accountId + "','" + data.virtualAddress + "','" + data.bankCode + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            return responseobject;


        }

    }
}
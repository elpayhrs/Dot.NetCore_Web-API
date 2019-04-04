using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GetAccountList.DataAccess;
using GetAccountList.Models;
using System.Data;
using System.Data.SqlClient;


namespace GetAccountList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAccountListController : ControllerBase
    {

        [HttpPost]
        public GetAccountListResponse Post([FromBody] GetAccountListRequest value)
        {

            var responseobject = new GetAccountListResponse() { status = "S", AccountMasterLists = new Files().GetAccounts() };
            // GetBankListResponse response = new GetBankListResponse( );


            getaccountlist data = new getaccountlist();


            data.datestamp = DateTime.Now;

            data.androidId = value.Deviceinfo.androidid;
            data.appName = value.Deviceinfo.appName;
            data.appVersionCode = value.Deviceinfo.appVersionCode;
            data.appVersionName = value.Deviceinfo.AppVersionName;
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



            data.pspId = value.RequestInfo.pspid;
            data.pspRefNo = value.RequestInfo.pspRefNo;
            data.profileId = value.RequestInfo.profileId;

            data.bankCode = value.bankCode;

            data.name = value.UserInfo.name;
            data.virtualAddress = value.UserInfo.virtualAddress;

            data.requestType = value.requestType;


            data.request = "POST";

            data.apiname = ControllerContext.RouteData.Values["controller"].ToString();


            string strcon = "Server=DESKTOP-N5AIHVF\\SRSSQL;Database=WEBAPI;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into getaccountlist ( data.datestamp , data.apiname, data.request, data.androidId, data.appName, data.appVersionCode, data.appVersionName, data.bluetoothMac, data.capability, data.deviceId, data.deviceType, data.geoCode, data.ip, data.location, data.mobileNo, data.os, data.regId, data.selectedSimSlot, data.simId, data.wifiMac, data.pspId, data.pspRefNo, data.profileId,data.bankCode, data.name, data.virtualAddress, data.requestType) values('" + data.datestamp + "', '" + data.apiname + "', '" + data.request + "','" + data.androidId + "', '" + data.appName + "', '" + data.appVersionCode + "', '" + data.appVersionName + "', '" + data.bluetoothMac + "', '" + data.capability + "', '" + data.deviceId + "', '" + data.deviceType + "', '" + data.geoCode + "', '" + data.ip + "', '" + data.location + "', '" + data.mobileNo + "', '" + data.os + "', '" + data.regId + "', '" + data.selectedSimSlot + "', '" + data.simId + "', '" + data.wifiMac + "', '" + data.pspId + "', '" + data.pspRefNo + "', '" + data.profileId + "', '" + data.bankCode + "', '" + data.name + "', '" + data.virtualAddress + "', '" + data.requestType + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();





            return responseobject;


        }

    }
}
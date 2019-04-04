using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InitiateSetMPIN.Models;
using InitiateSetMPIN.DataAccess;
using System.Data;
using System.Data.SqlClient;

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


            initiatesetmpindb data = new initiatesetmpindb();


            data.addInfo10 = value.Addinfo.addInfo10;
            data.addInfo9 = value.Addinfo.addInfo9;
            data.cardType = value.Addinfo.cardType;
            data.accountId = value.Addinfo.accountId;

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
            data.expiryDate = value.Deviceinfo.expiryDate;
            data.lastSixDigitDebitCardno = value.Deviceinfo.lastSixDigitDebitCardno;


            data.pspId = value.RequestInfo.pspId;
            data.pspRefNo = value.RequestInfo.pspRefNo;
            data.profileId = value.RequestInfo.profileId;
            data.virtualAddress = value.RequestInfo.virtualAddress;


            data.request = "POST";

            data.apiname = ControllerContext.RouteData.Values["controller"].ToString();


            string strcon = "Server=DESKTOP-N5AIHVF\\SRSSQL;Database=WEBAPI;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into initiatesetmpindb ( data.datestamp , data.apiname, data.addInfo10, data.addInfo9,data.cardType,data.accountId, data.request, data.androidId, data.appName, data.appVersionCode, data.appVersionName, data.bluetoothMac, data.capability, data.deviceId, data.deviceType, data.geoCode, data.ip, data.location, data.mobileNo, data.os, data.regId, data.selectedSimSlot, data.simId, data.wifiMac, data.expiryDate,  data.lastSixDigitDebitCardno, data.pspId, data.pspRefNo, data.profileId,data.virtualAddress) values('" + data.datestamp + "', '" + data.apiname + "', '" + data.request + "', '" + data.addInfo10 + "', '" + data.addInfo9 + "',  '" + data.cardType + "', '" + data.accountId + "', '" + data.androidId + "', '" + data.appName + "', '" + data.appVersionCode + "', '" + data.appVersionName + "', '" + data.bluetoothMac + "', '" + data.capability + "', '" + data.deviceId + "', '" + data.deviceType + "', '" + data.geoCode + "', '" + data.ip + "', '" + data.location + "', '" + data.mobileNo + "', '" + data.os + "', '" + data.regId + "', '" + data.selectedSimSlot + "', '" + data.simId + "', '" + data.wifiMac + "', '" + data.lastSixDigitDebitCardno + "', '" + data.expiryDate + "',  '" + data.pspId + "', '" + data.pspRefNo + "', '" + data.profileId + "', '" + data.virtualAddress + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();




            return responseobject;


        }

    }
}
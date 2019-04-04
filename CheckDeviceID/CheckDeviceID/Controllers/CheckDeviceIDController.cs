using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CheckDeviceID.Models;
using CheckDeviceID.DataAccess;
using System.Data;
using System.Data.SqlClient;

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



            checkdeviceid data = new checkdeviceid();


            data.addInfo10 = value.AddInfo.addInfo10;
            data.addInfo9 = value.AddInfo.addInfo9;


            data.datestamp = DateTime.Now;

            data.androidId = value.DeviceInfo.androidid;
            data.appName = value.DeviceInfo.appName;
            data.appVersionCode = value.DeviceInfo.appVersionCode;
            data.appVersionName = value.DeviceInfo.appVersionName;
            data.bluetoothMac = value.DeviceInfo.bluetoothMac;
            data.capability = value.DeviceInfo.capability;
            data.deviceId = value.DeviceInfo.deviceId;
            data.deviceType = value.DeviceInfo.deviceType;
            data.geoCode = value.DeviceInfo.geoCode;
            data.ip = value.DeviceInfo.ip;
            data.location = value.DeviceInfo.location;
            data.mobileNo = value.DeviceInfo.mobileNo;
            data.os = value.DeviceInfo.os;
            data.regId = value.DeviceInfo.regId;
            data.selectedSimSlot = value.DeviceInfo.selectedSimSlot;
            data.simId = value.DeviceInfo.simId;
            data.wifiMac = value.DeviceInfo.WifiMac;



            data.pspId = value.RequestInfo.pspId;
            data.pspRefNo = value.RequestInfo.pspRefNo;
            data.profileId = value.RequestInfo.profileId;


            data.request = "POST";

            data.apiname = ControllerContext.RouteData.Values["controller"].ToString();


            string strcon = "Server=DESKTOP-N5AIHVF\\SRSSQL;Database=WEBAPI;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into checkdeviceid (data.datestamp, data.apiname,  data.request, data.androidId,data.appName,data.appVersionCode,data.appVersionName,data.bluetoothMac,data.capability,data.deviceId,data.deviceType,data.geoCode,data.ip,data.location,data.mobileNo,data.os,data.regId,data.selectedSimSlot,data.simId, data.wifiMac, data.pspId, data.pspRefNo, data.profileId, data.addInfo10, data.addInfo9) values('" + data.datestamp + "', '" + data.apiname + "', '" + data.request + "','" + data.androidId + "', '" + data.appName + "', '" + data.appVersionCode + "', '" + data.appVersionName + "', '" + data.bluetoothMac + "', '" + data.capability + "', '" + data.deviceId + "', '" + data.deviceType + "', '" + data.geoCode + "', '" + data.ip + "', '" + data.location + "', '" + data.mobileNo + "', '" + data.os + "', '" + data.regId + "', '" + data.selectedSimSlot + "', '" + data.simId + "', '" + data.wifiMac + "', '" + data.pspId + "', '" + data.pspRefNo + "', '" + data.profileId + "', '" + data.addInfo10 + "', '" + data.addInfo9 + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();



            return responseobject;


        }

    }
}
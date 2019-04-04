using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Models
{
    public class Registration
    {
    }


    public class RegistrationResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public string registrationDate { get; set; }
        public RequstinfoRes[] requMasterList { get; set; }


    }
    public class RegistrationRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public RequestInfo RequestInfo { get; set; }
        public UserInfo userInfo { get; set; }
        public string accountId { get; set; }
        public string virtualAddress { get; set; }
    }


    public class DeviceInfo
    {

        public string androidid { get; set; }
        public string appName { get; set; }
        public string appVersionCode { get; set; }
        public string appVersionName { get; set; }
        public string bluetoothMac { get; set; }
        public string capability { get; set; }
        public string deviceId { get; set; }
        public string deviceType { get; set; }
        public string geoCode { get; set; }
        public string ip { get; set; }
        public string location { get; set; }
        public string mobileNo { get; set; }
        public string os { get; set; }
        public string regId { get; set; }
        public string selectedSimSlot { get; set; }
        public string simId { get; set; }
        public string WifiMac { get; set; }

    }

    public class RequestInfo
    {

        public string pspId { get; set; }
        public string pspRefNo { get; set; }
        public string pspRespRefNo { get; set; }
        public string profileId { get; set; }

    }

    public class UserInfo
    {
        public string altMobNo { get; set; }
        
        public string email { get; set; }
        public string mobileNo { get; set; }
        public secretDetails secretDetails { get; set; }
        public string name { get; set; }
        
    }
    public class secretDetails
    {
        public string secretAnswer { get; set; }
        public string quesId { get; set; }
    }

    public class RequstinfoRes
    {
        public string pspId { get; set; }
        public string pspRefNo { get; set; }
        public string pspRespRefNo { get; set; }
    }


}

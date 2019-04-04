using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetAccountList2.Models
{
    public class Accountlist2
    {
    }


    public class GetAccountList2Response
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public RequestInfoRes RequestInfoRes { get; set; }
        public UserInfoRes UserInfoRes { get; set; }
        public AccountList[] AccountMasterList { get; set; }
    }


    public class UserInfo
    {

        public string defVPAStatus { get; set; }
        public string name { get; set; }
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
        public string wifiMac { get; set; }
        public string recoveryOptionFlag { get; set; }


    }

    public class RequestInfo
    {
        public string pspId { get; set; }
        public string pspRefNo { get; set; }
        public string profileId { get; set; }
        public string requestType { get; set; }
        public string updateFlag { get; set; }

    }

    public class GetAccountList2Request
    {
        public DeviceInfo Deviceinfo { get; set; }
        public UserInfo Userinfo { get; set; }
        public RequestInfo Requestinfo { get; set; }
        public string appVersionCode { get; set; }
        public string bankCode { get; set; }


    }



    //response classes
    public class RequestInfoRes//this is for response class
    {
        public string pspId { get; set; }
        public string pspRefNo { get; set; }
    }

    public class UserInfoRes
    {
        public string name { get; set; }

        public string virtualAddress { get; set; }

    }

    public class AccountList
    {
        public string accId { get; set; }
        public string maskedAccountNumber { get; set; }
        public string mpinFlag { get; set; }
        public string ifscCode { get; set; }
        public string uPinLength { get; set; }
        public string bankId { get; set; }
        public string accountName { get; set; }
        public string bankCode { get; set; }
    }


}

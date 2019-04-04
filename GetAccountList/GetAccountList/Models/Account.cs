using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetAccountList.Models
{
    public class Account
    {
    }


    public class GetAccountListResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public AccountList[] AccountMasterLists { get; set; }
    }

    public class GetAccountListRequest
    {
        public Deviceinfo Deviceinfo { get; set; }
        public RequestInfo RequestInfo { get; set; }
        public UserInfo UserInfo { get; set; }
        public string bankCode { get; set; }
        public string requestType { get; set; }

    }

    public class Deviceinfo
    {

        public string androidid { get; set; }
        public string appName { get; set; }
        public string appVersionCode { get; set; }
        public string AppVersionName { get; set; }
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
        public string pspid { get; set; }
        public string pspRefNo { get; set; }
        public string profileId { get; set; }

    }

    public class AddInfo
    {

        public string addInfo9 { get; set; }
        public string addInfo10 { get; set; }

    }


    public class UserInfo
    {
        public string virtualAddress { get; set; }
        public string name { get; set; }
    }

    public class AccountList
    {
        public int accld { get; set; }
        public string maskedAccountNumber { get; set; }
        public string mpinFlag { get; set; }
        public string ifscCode { get; set; }
        public int uPinLength { get; set; }
        public int bankId { get; set; }
        public string accountName { get; set; }
        public string bankCode { get; set; }
    }



}

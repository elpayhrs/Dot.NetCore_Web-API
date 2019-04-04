using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetBankList.Models
{
    public class Banks
    {
    }

    public class GetBankListResponse
    {
        public string status { get; set; }
        public Bank[] bankMasterList { get; set; }


    }

    public class Bank
    {
        public int accId { get; set; }
        public string bankCode { get; set; }
        public int bankId { get; set; }
        public string bankName { get; set; }
        public bool canShowBalance { get; set; }
        public bool checkedAccount { get; set; }
        public int uPinLength { get; set; }

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
    public class AddInfo
    {

        public string addInfo10 { get; set; }
        public string addInfo9 { get; set; }

    }
    public class RequestInfo
    {

        public string pspId { get; set; }
        public string pspRefNo { get; set; }
        public string profileId { get; set; }

    }
    public class GetBankListRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public AddInfo Addinfo { get; set; }
        public RequestInfo RequestInfo { get; set; }
    }


}

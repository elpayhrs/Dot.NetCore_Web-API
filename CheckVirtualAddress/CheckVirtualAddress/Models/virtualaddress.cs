using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckVirtualAddress.Models
{
    public class virtualaddress
    {
    }


    public class CheckvirtualAddressResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public PayeeType PayeetypeRes { get; set; }

        public VpaDetails[] VpaDetailsMasterList { get; set; }

    }

    public class CheckVirtualAddressRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public AddInfo Addinfo { get; set; }
        public PayeeType Payeetype { get; set; }
        public RequestInfo RequestInfo { get; set; }
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

    }
    public class AddInfo
    {

        public string addInfo10 { get; set; }
        public string addInfo9 { get; set; }

    }
    public class PayeeType
    {
        public string virtualAddress { get; set; }

    }
    public class RequestInfo
    {

        public string pspId { get; set; }
        public string pspRefNo { get; set; }
        public string profileId { get; set; }
        public string vAReqType { get; set; }

    }

    //response classes

    public class requestInfo
    {
        public string pspid { get; set; }
        public string pspRefNo { get; set; }
    }

    public class PayeeTypeRes
    {
        public string defVPAStatus { get; set; }
        public string isVerified { get; set; }
        public string name { get; set; }
        public string spamRefNo { get; set; }
        public string virtualAddress { get; set; }


    }
    public class VpaDetails
    {
        public string fVaddr { get; set; }
        public string fName { get; set; }
        public string defVPAStatus { get; set; }
    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfirmSetMPIN.Models
{
    public class CSmpin
    {
    }

    public class ConfirmSetMPINResponse
    {
        public string status { get; set; }
        public string statusDesc { get; set; }
        public string apiResp { get; set; }       
        public OtpCred[] Otpcredmaster { get; set; }
        public string npciTransId { get; set; }
    }

    public class ConfirmSetMPINRequest
    {
        public DeviceInfo Deviceinfo { get; set; }       
        public AddInfo Addinfo { get; set; }
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
        public string WifiMac { get; set; }

    }

    public class OtpCred
    {

        public string atmCrdLength { get; set; }
        public string credentialDataCode { get; set; }
        public string credentialDataKi { get; set; }
        public string credentialDataLength { get; set; }
        public string credentialDataValue { get; set; }
        public string credentialSubType { get; set; }
        public string credentialType { get; set; }

    }

    public class AddInfo
    {

        public string addInfo9 { get; set; }
        public string addInfo10 { get; set; }

    }


    public class RequestInfo
    {
        public string pspId { get; set; }
        public string pspRefNo { get; set; }
        public String profileId { get; set; }
    }


}

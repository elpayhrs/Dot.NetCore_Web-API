using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitiateSetMPIN.Models
{
    public class setmpin
    {
    }

    public class InitiateSetMPINResponse
    {
        public string status { get; set; }
        public Cred[] CredMasterList { get; set; }
    }
    public class AddInfo
    {

        public string addInfo10 { get; set; }
        public string addInfo9 { get; set; }
        public string cardType { get; set; }
        public string accountId { get; set; }

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
        public string expiryDate { get; set; }
        public string lastSixDigitDebitCardno { get; set; }

    }
    public class RequestInfo
    {
        public string pspId { get; set; }
        public string pspRefNo { get; set; }
        public string profileId { get; set; }
        public string virtualAddress { get; set; }

    }
    public class InitiateSetMPINRequest
    {
        public DeviceInfo Deviceinfo { get; set; }
        public AddInfo Addinfo { get; set; }
        public RequestInfo RequestInfo { get; set; }
    }


    //Response classes

    public class libResp
    {

    }
    public class RequestInfoRes
    {
        public string pspId { get; set; }
        public string pspRefno { get; set; }
        public string upitranRefNo { get; set; }
        public string npciTranId { get; set; }
        public string otpNpciTranId { get; set; }

    }

    public class DeviceInfoRes
    {
        public string deviceId { get; set; }
        public string mobileNo { get; set; }
    }
    public class PayerType
    {
        public string virtualAddress { get; set; }
        public string name { get; set; }
        public string payerBankName { get; set; }
        public string tranactionNote { get; set; }
    }
    public class Cred
    {
        public string credentialDataType { get; set; }
        public int credentialDataLength { get; set; }
        public int atmCrdLength { get; set; }
        public int otpCrdLength { get; set; }
        public string otpCrdType { get; set; }
    }
}

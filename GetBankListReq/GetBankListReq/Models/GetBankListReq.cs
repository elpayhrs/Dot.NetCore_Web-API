using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetBankListReq.Models
{
    public class GetBankListReqJson
    {
        public Deviceinfo Deviceinfo { get; set; }
        public Addinfo Addinfo { get; set; }
        public RequestInfo RequestInfo { get; set; }

    }
    public class Deviceinfo
    {

        public string Androidid { get; set; }
        public string AppName { get; set; }
        public string AppVersionCode { get; set; }
        public string AppVersionName { get; set; }
        public string BluetoothMac { get; set; }
        public string Capability { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string GeoCode { get; set; }
        public string Ip { get; set; }
        public string Location { get; set; }
        public string MobileNo { get; set; }
        public string Os { get; set; }
        public string RegId { get; set; }
        public string SelectedSimSlot { get; set; }
        public string SimId { get; set; }
        public string WifiMac { get; set; }

    }
    public class Addinfo
    {

        public string AddInfo { get; set; }
        public string AddInfo9 { get; set; }

    }
    public class RequestInfo
    {

        public string PspId { get; set; }
        public string PspRefNo { get; set; }
        public string ProfileId { get; set; }

    }

    public class GetBankListResponse
    {
        public string Status { get; set; }
        public Bank[] BankMasterList { get; set; }
    }

    public class Bank
    {
        public int AccId { get; set; }
        public string BankCode { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
        public bool CanShowBalance { get; set; }
        public bool CheckedAccount { get; set; }
        public int UPinLength { get; set; }

    }
}

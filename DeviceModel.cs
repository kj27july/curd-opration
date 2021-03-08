using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//did some changes to check fork
namespace Assignment1_os.Models
{
    public class DeviceModel
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String OsType { get; set; }
        public int Battery { get; set; }
        public int AvailableMemory { get; set; }
    }
}

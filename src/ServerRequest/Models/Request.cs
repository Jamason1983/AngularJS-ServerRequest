using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerRequest.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string ServerName { get; set; }
        public string Requestor { get; set; }
        public string Domain { get; set; }
        public string Datacenter { get; set; }
        public string OS { get; set; }
        public int Cores { get; set; }
        public int RAM { get; set; }
        public List<DriveConfig> Drives { get; set; }
    }

    public class DriveConfig
    {
        public Int64 Id { get; set; }
        public int Size { get; set; }
        public string DriveId { get; set; }
        public string DisplayName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerRequest.Models
{
    public class Request
    {
        internal string requestor;

        public int Id { get; set; }
        public string ServerName { get; set; }
        public string Requestor { get; set; }

    }
}

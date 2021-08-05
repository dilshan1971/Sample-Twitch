using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Contracts
{
    public interface PingRequest
    {
        public string Ping { get; set; }
        public string SecondPing { get; set; }
    }
}

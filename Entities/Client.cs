using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public List<Order> Orders { get; set; }
        public string ClientNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

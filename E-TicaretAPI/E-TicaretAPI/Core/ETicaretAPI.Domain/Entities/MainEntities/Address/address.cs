using ETicaretAPI.Domain.Entites.MainEntites.Customer;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entites.MainEntites.Address
{
    public class address
    {
        public int AddressID { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Neighbourhood { get; set; }
        public string? FullAddress { get; set; }

    }
}

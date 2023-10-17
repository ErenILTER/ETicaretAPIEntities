using ETicaretAPI.Domain.Entites.MainEntites.Address;
using ETicaretAPI.Domain.Entites.MainEntites.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entites.MainEntites.Product
{
    public class product
    {
        public int ProductNo { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductCategory { get; set; }
        public ICollection<customer> customers { get; set; }
    }
}


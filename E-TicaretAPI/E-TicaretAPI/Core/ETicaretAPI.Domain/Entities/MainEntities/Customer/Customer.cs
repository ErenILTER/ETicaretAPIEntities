using ETicaretAPI.Domain.Entites.MainEntites.Address;
using ETicaretAPI.Domain.Entites.MainEntites.ıddata;
using ETicaretAPI.Domain.Entites.MainEntites.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entites.MainEntites.Customer
{
    public class customer
    {
        public int CustomerID { get; set; }
        public IDData IDData { get; set; }
        public address address { get; set; }
        public ICollection<product> products { get; set; }
    }
}

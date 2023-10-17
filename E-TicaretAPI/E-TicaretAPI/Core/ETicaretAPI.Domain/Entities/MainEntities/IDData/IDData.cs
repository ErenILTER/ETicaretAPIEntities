using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entites.MainEntites.Address;
using ETicaretAPI.Domain.Entites.MainEntites.Customer;

namespace ETicaretAPI.Domain.Entites.MainEntites.ıddata
{
    public class IDData
    {
        [Key]
        public int IDCardNo { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}

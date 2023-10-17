using ETicaretAPI.Domain.Entites.MainEntites.Customer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Contexts
{
    public class ETicaretAPIDbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<customer> Customers { get; set; }
    }
}

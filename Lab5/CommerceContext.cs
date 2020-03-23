using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class CommerceContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public CommerceContext()
        : base("name=CommerceContext")
        {
        }
    }
}

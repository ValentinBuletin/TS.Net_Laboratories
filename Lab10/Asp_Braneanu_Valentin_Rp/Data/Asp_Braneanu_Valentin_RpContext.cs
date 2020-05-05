using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Braneanu_Valentin_Rp.Models;

namespace Asp_Braneanu_Valentin_Rp.Data
{
    public class Asp_Braneanu_Valentin_RpContext : DbContext
    {
        public Asp_Braneanu_Valentin_RpContext (DbContextOptions<Asp_Braneanu_Valentin_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

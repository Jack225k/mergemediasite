using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mergemediawebsite.Models
{
    public class ContextClass : DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options) : base(options)
        {

        }

        public DbSet<Mergemediawebsite.Models.HostingTable> HostingTables { get; set; }
        public DbSet<Mergemediawebsite.Models.Portfolio> Portfolios { get; set; }
        public DbSet<Mergemediawebsite.Models.login> logins { get; set; }
        
    }
}

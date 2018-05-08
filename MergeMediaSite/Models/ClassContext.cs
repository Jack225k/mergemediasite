using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MergeMediaSite.Models
{
    public class ClassContext : DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> options) : base(options)
        {

        }

        public DbSet<MergeMediaSite.Models.HostingTable> HostingTables { get; set; }
        public DbSet<MergeMediaSite.Models.Portfolio> Portfolios { get; set; }

    }
}

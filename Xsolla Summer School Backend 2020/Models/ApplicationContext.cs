using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xsolla_Summer_School_Backend_2020.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        
        }
    }
}

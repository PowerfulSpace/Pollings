using Microsoft.EntityFrameworkCore;
using PS.PollingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

using System.Text;
using System.Threading.Tasks;

namespace PS.PollingSystem.Application
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Poll> Polls { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder); 
        }
    }
}

#nullable enable
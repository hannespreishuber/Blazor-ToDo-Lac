using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp2.Model;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace BlazorApp2.Model
{
    //add-migration
    //>sqllocaldb i mssqllocaldb
    public class AufgabenContext : DbContext
    {
        public ViewModel VM { get; set; }

        public IConfiguration Configuration { get; }

        public AufgabenContext(IConfiguration configuration, DbContextOptions<AufgabenContext> options) : base(options)
        {
            Configuration = configuration;


        }
        public virtual DbSet<Aufgabe> Aufgaben { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ToDoDatabase"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}

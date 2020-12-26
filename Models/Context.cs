using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Armazen.Models
{
    public class Context : DbContext
    {
        public DbSet<Utilitario> Utilitarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DIO_Armazen;Integrated Security=True");
        }
    }
}

using InchirieriCaseteVideo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriCaseteVideo.DBContext
{
    class InchirieriDbContext : DbContext
    {
        public InchirieriDbContext()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {
                Console.WriteLine("Tabelele din baza de date reflecta structura claselor din proiect");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=InchirieriCaseteVideo.db");
        }

        public DbSet<Client> Clienti { get; set; }
        public DbSet<Inchiriere> Inchierieri { get; set; }

    } 
}

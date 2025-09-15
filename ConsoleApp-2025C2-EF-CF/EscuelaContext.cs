using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2025C2_EF_CF
{
    internal class EscuelaContext : DbContext
    {
        public DbSet<Estudiante> Estdiante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { optionsBuilder.UseSqlServer(@"Server=A-PROFH-360;Database=CF-2025C2-12C-Escuela;Trusted_Connection=True;Trust Server Certificate=true"); }
    }
}

using Microsoft.EntityFrameworkCore;
using MSIF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=DBMSIF; Integrated Security=SSPI; TrustServerCertificate=True");
        }

        public DbSet<Contatos> Contatos { get; set; }
        public DbSet<Recado> Recado { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }
    }
}


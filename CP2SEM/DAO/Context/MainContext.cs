using CP2SEM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP2SEM.DAO.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteMovimentacao> ClienteMovimentacao { get; set; }
        public DbSet<Movimentacoes> Movimentacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = tcp:sqlserver-rm86327.database.windows.net, 1433; Initial Catalog = dimdim; Persist Security Info = False; User ID = adminSql; Password = Devops@fiap2021; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");
        }
    }
}

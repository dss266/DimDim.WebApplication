using CP2SEM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CP2SEM.DAO.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteMovimentacao> ClienteMovimentacao { get; set; }
        public DbSet<Movimentacoes> Movimentacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = builder.Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");


            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

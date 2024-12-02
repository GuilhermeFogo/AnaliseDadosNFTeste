using Infra.Endidade;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class DataSQLServerContext : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<NotasFiscais> NotasFiscais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database= MyNFE_sys;User ID =sa; Password=123456;Persist Security Info=True;MultipleActiveResultSets=True");
        }
    }
}

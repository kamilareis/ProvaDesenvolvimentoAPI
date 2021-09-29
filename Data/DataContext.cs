using ProvaDesenvolvimentoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvaDesenvolvimentoAPI.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

         public DbSet<Filme> Filmes { get; set; }
    }
}
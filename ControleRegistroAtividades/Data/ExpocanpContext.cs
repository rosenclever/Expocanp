using ControleRegistroAtividades.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleRegistroAtividades.Data
{
    public class ExpocanpContext : DbContext
    {
        public ExpocanpContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Sala> Salas { get; set; }
    }
}

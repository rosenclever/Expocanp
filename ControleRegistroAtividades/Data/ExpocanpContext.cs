using ControleRegistroAtividades.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleRegistroAtividades.Data
{
    public class ExpocanpContext : DbContext
    {
        public ExpocanpContext(DbContextOptions<ExpocanpContext> options) : base(options)
        {
        }
        public DbSet<Sala> Salas { get; set; }
    }
}

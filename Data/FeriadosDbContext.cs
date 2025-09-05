using Microsoft.EntityFrameworkCore;
using FeriadosApi.Models;

namespace FeriadosApi.Data
{
    public class FeriadosDbContext: DbContext
    {
        public FeriadosDbContext(DbContextOptions<FeriadosDbContext> options) : base(options)
        {
        }
        public DbSet<Feriado> Feriados { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using ProAgil.webAPI.Model;

namespace ProAgil.webAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet<Evento> Eventos {get; set;}
    }
}
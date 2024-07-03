
using canciones.Entidad;
using Microsoft.EntityFrameworkCore;

namespace canciones.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) :base (options){ 
        

        }
        public DbSet<Canciones> canciones { get; set; }

     
    }
}

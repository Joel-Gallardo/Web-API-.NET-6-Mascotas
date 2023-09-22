using Microsoft.EntityFrameworkCore;

namespace MascotasWebAPI.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        //creando la tabla
        public DbSet<Mascota> Mascotas { get; set;}
    }
}

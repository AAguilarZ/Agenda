using AgendaContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaContactos.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }
        // agregar los modelos aqui
        public DbSet<Contacto> Contacto { get; set; }

    }
}

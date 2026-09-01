using Microsoft.EntityFrameworkCore;

namespace MiApiCuadrado_ConBaseDeDatos
{
    public class HarryPotterDBContext : DbContext
    {
        public  HarryPotterDBContext(DbContextOptions<HarryPotterDBContext> options) : base(options)
    {
    }

    public DbSet<Personajes> Personaje { get ; set; }
    public DbSet<Casas> Casa { get ; set; }
    public DbSet<TiposSangresMagicas> TipoSangreMagica { get ; set; }
    public DbSet<VaritasMagicas> VaritaMagica { get ; set; }


    }
    
}
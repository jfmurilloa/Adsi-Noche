using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppContext:DbContext
    {
        //Atributos
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Patrocinador> Patrocinadores {get;set;}
        public DbSet<Colegio> Colegios {get;set;}
        public DbSet<Torneo> Torneos {get;set;}

        //<crear la conexion con la base de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Eventos2930");
                
            }
        }

    }
}
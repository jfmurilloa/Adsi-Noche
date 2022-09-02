using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
   public interface IRMunicipio
    {
        public IEnumerable<Municipio> ListarMunicipios();       
        public bool CrearMunicipio(Municipio municipio);
        public bool ActualizarMunicipio(Municipio municipio);
        public bool EliminarMunicipio(int idMunicipio);
        public Municipio BuscarMunicipio(int idMunicipio);
    }
}
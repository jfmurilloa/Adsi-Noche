using Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Persistencia
{
    public class RMunicipio:IRMunicipio
    {
        //Atributos
        private readonly AppContext _appContext;

        //Metodos
        //Constructor
        public RMunicipio(AppContext appContext)
        {
            this._appContext= appContext;
        }

        //Metodos para transacciones sobre la base de datos

        public IEnumerable<Municipio> ListarMunicipios()
        {
            return _appContext.Municipios;
        }
        public bool CrearMunicipio(Municipio municipio)
        {
            bool creado=false;
            try
            {
                _appContext.Municipios.Add(municipio);
                _appContext.SaveChanges();
                creado=true;
            }
            catch (Exception e)
            {
                creado=false;
            }           
            return creado;
        }
        public bool ActualizarMunicipio(Municipio municipio)
        {
            bool actualizado= false;
            var mun= _appContext.Municipios.Find(municipio.Id);
            if(mun != null)
            {
                try
                {
                    mun.Nombre= municipio.Nombre;
                    _appContext.SaveChanges();
                    actualizado=true;
                }
                catch (Exception e)
                {                    
                    actualizado=false;
                }
                
            }
            return actualizado;
        }
        public bool EliminarMunicipio(int id)
        {
           bool eliminado=false;
           var mun= _appContext.Municipios.Find(id);
           if(mun != null)
           {
                try
                {
                    _appContext.Municipios.Remove(mun);
                    _appContext.SaveChanges();
                    eliminado= true;
                }
                catch (Exception e)
                {
                    eliminado=false;                    
                }
           }
           return eliminado; 
        }
        public Municipio BuscarMunicipio(int id)
        {
            Municipio municipio= _appContext.Municipios.Find(id);
            return municipio;
        }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Torneo
    {
        //Propiedades

        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Categoria {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Modalidad {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaFin {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Equipos {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(15, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Fixture {get;set;}

        //Relacion con Municipio
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int MunicipioId {get;set;}
        //public Municipio Municipio {get;set;}



    }
}
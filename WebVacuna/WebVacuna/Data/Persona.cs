using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVacuna.Data
{
    public class Persona
    {
        public int Id { get; set; }
        public string Dpi { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string TercerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string ApellidoCasada { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Covid19positivo { get; set; }
        public DateTime? FechaDeContagio { get; set; }
        public string TipoVacuna { get; set; }
        public DateTime? FechaDosis1 { get; set; }
        public DateTime? FechaDosis2 { get; set; }
        public string CentroDeServicio { get; set; }
    }
}

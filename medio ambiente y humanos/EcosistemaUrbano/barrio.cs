using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EcosistemaUrbano
{
    [Table("Barrios")]
    public class Barrio
    {
        [Key]
        public int NumeroBarrio { get; set; }
        public string Nombre { get; set; }
        
        public List<Persona> ListaPersonasBarrio { get; set; }
        
        
    }
}

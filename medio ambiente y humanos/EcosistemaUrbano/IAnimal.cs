using System;
using System.Collections.Generic;
using System.Text;

namespace EcosistemaUrbano
{
    interface IAnimal
    {
        string Nombre { get; set; }
       string TipoMascotaGenero { get; set; }
       string ComidaFavorita { get; set; }
        public string Comer();
        string Comunicarse();
    }
}

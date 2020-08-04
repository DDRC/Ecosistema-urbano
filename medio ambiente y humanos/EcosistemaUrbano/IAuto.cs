using System;
using System.Collections.Generic;
using System.Text;

namespace EcosistemaUrbano
{
    interface IAuto
    {
        string Placa { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        string Conducir();
        string Encender();
        string CrearPolucion();
    }
}

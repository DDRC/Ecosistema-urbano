using System;
using System.Collections.Generic;
using System.Text;

namespace EcosistemaUrbano
{
    public interface IPersonaAccion
    {
        Guid Id { get; }
        int AñoNacimiento { get; set; }
        int CalculoEdad();
    }
}

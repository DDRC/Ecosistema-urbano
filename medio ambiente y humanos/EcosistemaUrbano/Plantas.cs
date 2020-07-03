using System;
using System.Collections.Generic;
using System.Text;

namespace EcosistemaUrbano
{
    public class Plantas
    {
        public int Id { get; set; }
        public string NombreComun { get; set; }
        public string Comestible { get; set; }
        public string Habito { get; set; }
        public string Florecer()
        {
            return $"{NombreComun} acaba de florecer.";
        }
        public string Comunicarse()
        {
            return "Todas las plantas pueden comunicarse con las adyacentes mediante las raices";
        }
        public string Germinar()
        {
            return $"la semilla de {NombreComun} esta creciendo";
        }
        public string DarFrutos()
        {
            return $"{NombreComun} dara frutos, muy pronto...";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EcosistemaUrbano
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public Autos Auto { get; set; }
        public Mascota Mascota { get; set; }
        public Plantas Planta { get; set; }
        public string Presentarse()
        {
            return $"{Nombre} {Apellido}";
        }
        public string Comer()
        {
            return $"{Nombre} esta listo para comer su comidita";
        }
        public string Conducir()
        {
            return $"{Nombre} va ha conducir su {Auto.Marca} {Auto.Modelo}";
        }
        public string Jugar()
        {
            return $"a jugar con su { Mascota.TipoMascotaGenero} {Mascota.Nombre}";

        }
        public string Plantar()
        {
            return $"{Nombre} Plantara una {Planta.NombreComun} en el jardin de su patio";
        }
    }
}

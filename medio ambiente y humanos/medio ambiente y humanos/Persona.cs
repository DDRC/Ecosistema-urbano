using System;
using System.Collections.Generic;
using System.Text;

namespace medio_ambiente_y_humanos
{
    class Persona
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
            if (Genero.ToLower() == "hembra")
            {
                return $"A jugar con su la {Mascota.TipoDeMascota} {Mascota.Nombre}";
            }
            else if (Genero.ToLower() == "macho")
            {
                return $"A jugar con su el {Mascota.TipoDeMascota} {Mascota.Nombre}";
            }
            else {
                return $"A jugar con {Mascota.Nombre}";
            }
            
        }
        public string Plantar()
        {
            return $"{Nombre} Plantara una {Planta.NombreComun} en el jardin de su patio";
        }
    }
}

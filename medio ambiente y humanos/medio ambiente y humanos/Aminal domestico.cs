using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace medio_ambiente_y_humanos
{
    class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoDeMascota { get; set; }
        public string Genero { get; set; }
        public string ComidaFavorita { get; set; }
        public Plantas Planta { get; set; }

        public string Comunicarse()
        {
            if (TipoDeMascota.ToLower()=="perro")
            {
                return "Guau Guau !!";
            }else if (TipoDeMascota.ToLower() == "gato")
            {
                return "Miau Miua";
            }
            else if (TipoDeMascota.ToLower() == "pajaro")
            {
                return " Pio Pio";
            }
            else
            {
                Console.Write( $"¿Que dice el {TipoDeMascota} ? ");
                 string sonido= Console.ReadLine();
                return sonido;
            }

        }
        public string Comer()
        {
            return $"{this.Nombre} le gusta esta comer sus {this.ComidaFavorita}";
        }
        public string Dormir()
        {
            if (Genero.ToLower() == "hembra")
            {
                return $"La {this.Nombre} ya se fue a dormir. zzz";
            }
            else if (Genero.ToLower() == "macho")
            {
                return $"El {this.Nombre} ya se fue a dormir. zzz";
            }
            else
            {
                return "Solo puede ser Hembra o Macho";
            }
        }
        public string Dispersar()
        {
            if (Genero.ToLower() == "hembra")
            {
                return $"La {this.Nombre} dispersa las semillas de {Planta.NombreComun}";
            }
            else if (Genero.ToLower() == "macho")
            {
                return $"El {this.Nombre} dispersa las semillas de {Planta.NombreComun}";
            }
            else
            {
                return "Solo puede ser Hembra o Macho";
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace EcosistemaUrbano
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoMascotaGenero { get; set; }
        //public string Genero { get; set; }
        public string ComidaFavorita { get; set; }
        public Plantas Planta { get; set; }

        public string Comunicarse()
        {
            if (TipoMascotaGenero.ToLower()=="perro")
            {
                return "Guau Guau !!";
            }else if (TipoMascotaGenero.ToLower() == "gato")
            {
                return "Miau Miua";
            }
            else if (TipoMascotaGenero.ToLower() == "pajaro")
            {
                return " Pio Pio";
            }
            else
            {
                Console.Write( $"¿Que dice el {TipoMascotaGenero} ? ");
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
            return $" {this.Nombre} se fue a dormir. zzz";
        }
        public string Moverse()
        {
            return $" {this.Nombre} corrio";
        }
    }
}

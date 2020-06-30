using System;
using System.Collections.Generic;
using System.Text;

namespace medio_ambiente_y_humanos
{
    class Insectos
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public float Tamaño { get; set; }
        public string Color { get; set; }
        public string Alimentacion { get; set; }
        public string Vuela { get; set; }
        public Plantas planta { get; set; }
        public string Mover() {
            if (Vuela.ToLower() == "si")
            {
                return $"El {Tipo} esta volando";
            }
            else if (Vuela.ToLower() == "no")
            {
                return $"El {Tipo} esta caminando";
            }
            else {
                return "Solo puedes ingresar si o no";
            }
        }
        public string Comer() {
            return $"{Tipo} esta comiendo {Alimentacion}";
        }
        public string Polinizar() {
            return $"mientras el {Tipo} se ha polinizado a la {planta.NombreComun}";
        }
        public string Escapar() {
            return $"!!Es hora de escapar {Tipo}¡¡";
        }
    }
}

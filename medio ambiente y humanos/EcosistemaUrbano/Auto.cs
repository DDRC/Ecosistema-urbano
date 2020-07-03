using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace EcosistemaUrbano
{
   public class Autos
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        //public float ConsumoDieseGal { get; set; }
    public double DistanciaRecorrida { get; set; }
        public Persona Propietario { get; set; }
        public string Conducir()
        {
            return $"{Propietario.Nombre} conduce este {Marca} {Modelo}";
        }
        public string Encender()
        {
            return $"El {Marca} {Modelo} se enciende, Brum brum!!";
        }
        public string CrearPolucion()
        {
            var polucion = this.DistanciaRecorrida* 0.025 * 9.97;
            var CO2 =Math.Round(polucion,2);
            return $"genero {CO2} Kg de CO2";
        }
        public string Estacionar()
        {
            return $"{Propietario.Nombre} despues de conducir estaciona el {Marca} {Modelo}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace medio_ambiente_y_humanos
{
    class Autos
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double ConsumoGasolinaGal { get; set; }
        public Persona Propietario { get; set; }
        public string Conducirse()
        {
            return $"{Propietario.Nombre} conduce este {Marca} {Modelo}";
        }
        public string Encenderse()
        {
            return $"El {Marca} {Modelo} se enciende, Brum brum!!";
        }
        public string CrearPolucion()
        {
            var polucion = this.ConsumoGasolinaGal * 8.88;
            return $"Al encender y conducir el Auto, {polucion} gramos de CO2 se liberan al ambiente";
        }
        public string Estacionarse()
        {
            return $"{Propietario.Nombre} despues de conducir estaciona el {Marca} {Modelo}";
        }
    }
}

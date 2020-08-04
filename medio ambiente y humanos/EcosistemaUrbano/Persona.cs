using System;
using System.Collections.Generic;
using System.Text;

namespace EcosistemaUrbano
{
    public class Persona :IPersonaAccion
    {
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public string Genero { get; set; }
        public Autos Auto { get; set; }
        public Mascota Mascota { get; set; }
        public Plantas Planta { get; set; }
        private  Guid _id;
        protected int _añoNacimiento;
        public Guid Id { get => _id; }
        public int AñoNacimiento
        {
            get => _añoNacimiento;
            set => _añoNacimiento = value;
        }
        

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

        public int CalculoEdad()
        {
           var añoActual = DateTime.Today.ToString("yyyy");
            var valorAñoActual = int.Parse(añoActual);
            var edad = valorAñoActual - _añoNacimiento;
            return edad;
        }
    }
}

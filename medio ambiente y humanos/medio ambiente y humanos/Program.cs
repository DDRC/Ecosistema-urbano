using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace medio_ambiente_y_humanos
{
    class AmbienteUrbano
    {
        static void Main(string[] args)
        {
            var aleatorio= new Random();
            var plant=new Plantas
            {
                Id = aleatorio.Next(),
                NombreComun = "Diente de leon",
                Comestible = "si",
                Habito = "hierba"
            };
            var Persona = new Persona
            {
                Id = aleatorio.Next(),
                Nombre = "Heidy",
                Apellido = "Rivas",
                Edad = 7,
                Genero = "Femenino",
                Auto = new Autos
                {
                    Id = aleatorio.Next(),
                    Placa = "PAEO-756",
                    Marca = "Chevrolet",
                    Modelo="Aveo",
                    ConsumoGasolinaGal = 12.3
                },
                Planta =plant,
                Mascota = new Mascota
                {
                    Id = aleatorio.Next(),
                    Nombre = "Manchas",
                    Genero = "Hembra",
                    TipoDeMascota = "Perro",
                    ComidaFavorita = "Sopa",
                    Planta=plant
                }
                
            };
            Console.Write($"Un dia {Persona.Presentarse()}, fue al parque a");
            Console.Write($" {Persona.Jugar()} y se divirtieron tanto que su {Persona.Mascota.Nombre}, corrio entre {Persona.Planta.NombreComun}");
            Console.Write($" {Persona.Mascota.Dispersar()}, cuando regresaban a casa lo hicieron en su {Persona.Auto.Marca} {Persona.Auto.Modelo}");
            Console.WriteLine($" Al final del dia mientras dormia {Persona.Nombre} soño como la  {Persona.Planta.Germinar()}");
            Console.Write("Presione Enter para salir");
            Console.ReadKey();
        }
    }
}

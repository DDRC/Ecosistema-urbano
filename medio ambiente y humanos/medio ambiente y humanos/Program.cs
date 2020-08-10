using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using EcosistemaUrbano;

namespace medio_ambiente_y_humanos
{
    class AmbienteUrbano
    {
        static void Main()
        {
            var aleatorio= new Random();
            var plant=new Plantas
            {
                Id = aleatorio.Next(),
                NombreComun = "diente de leon",
                Comestible = "si",
                Habito = "hierba"
            };
            var Persona = new Persona
            {
                Barrio = new Barrio { NumeroBarrio = 1, Nombre = "Chillogallo" },
                Nombre = "Juan",
                Apellido = "Bautista",
                AñoNacimiento = 1995,
                Genero = "Masculino",
                Auto = new Autos
                {
                    Id = aleatorio.Next(),
                    Placa = "PAE-756",
                    Marca = "Chevrolet",
                    Modelo="Aveo",
                    DistanciaRecorrida = 2
                },
                Planta =plant,
                Mascota = new Mascota
                {
                    Id = aleatorio.Next(),
                    Nombre = "Manchas",
                    TipoMascotaGenero = "Perra",
                    ComidaFavorita = "Sopa",
                    Planta=plant
                }
                
            };

           

            
            Console.Write($"Diariamente {Persona.Presentarse()}, una persona promedio, que a diario interactua con su entorno decide");
            Console.Write($" salir {Persona.Jugar()} y mientras jugaban, {Persona.Mascota.Moverse()} cerca a unas plantas de {Persona.Planta.NombreComun} dispersando sus semillas, permitiendo así que la especie perpetue;");
            Console.WriteLine($" de regreso a casa en su {Persona.Auto.Marca} {Persona.Auto.Modelo} en un recorrido de {Persona.Auto.DistanciaRecorrida} KM, {Persona.Auto.CrearPolucion()}, consciente de las emisiones de CO2 de su auto, planto árboles y arbustos frutales, que además de los frutos, capta CO2 produciendo oxígeno.");
            Console.WriteLine("Presione Enter para Guardar informacion de la persona en c:/informacionpersona");
            var save=new DatosAGuardar().GuardarDatos(Persona);
            Console.ReadKey();
            
            Console.Write("Presione Enter para Salir");
            Console.ReadKey();
        }
    }
}

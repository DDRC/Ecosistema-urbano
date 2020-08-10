using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EcosistemaUrbano
{
    public class DatosAGuardar
    {
        string ruta = "C:/InformacionPersona/DatosPersona.txt";
        string rutaDirectorio = "C:/InformacionPersona/";
        public string GuardarDatos(Persona DatosPersona)
        {
            
            
            Directory.CreateDirectory(rutaDirectorio);
            if (!File.Exists(ruta)|| File.Exists(ruta))
            {
                
                string contenido = $"hola mundo aqui mi primer archivo creado con C#," +
                $"Los datos de {DatosPersona.Nombre}" +
                $"\nNombre: {DatosPersona.Nombre}" +
                $"\nApellido: {DatosPersona.Apellido}" +
                $"\nCedula: {DatosPersona.Id}" +
                $"\nEdad: {DatosPersona.CalculoEdad()}" +
                $"\nBarrio donde vive: {DatosPersona.Barrio.Nombre}";
                File.WriteAllText(ruta, contenido, Encoding.UTF8);
            }
            return "Guardado con exito";

        }
    }
}

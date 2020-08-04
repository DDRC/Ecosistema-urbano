using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcosistemaUrbano
{
    class deportista:Persona
    {
        public string gymFavorito  { get; set; }
        public int cuantasRepeticionesAguanta  { get; set; }
        private bool profesional=false;
        public string Series(string ejercicio)
        {
            return $"{this.Nombre} realiza {this.cuantasRepeticionesAguanta}  {ejercicio}";
        }
        public string Compite()
        {
            if (profesional)
            {
                return "puede compertir en eventos internacionales";
            }
            else
            {
                return "puede competir en eventos nacionales";
            }
        }
    }
}

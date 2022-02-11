using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Cadenas
{
    public class Cadenas
    {
        public string Cadena1 { get; set; }
        public string Cadena2 { get; set; }
        public string Cadena3 { get; set; }
        public Cadenas(string cadena1, string cadena2, string cadena3)
        {
            Cadena1 = cadena1;
            Cadena2 = cadena2;
            Cadena3 = cadena3;
        }
        public void ManejoDeCadenas()
        {
            Console.WriteLine($"Elimiinacion de caracteres{Environment.NewLine}Cadena: {Cadena1} tamaño: {Cadena1.Length}");
            string resultado = Cadena1.Remove(0, Cadena1.Length - 8);
            Console.WriteLine($"Resultado con funcion Remove: {resultado}");
            resultado = Cadena2.Substring(Cadena1.Length - 8, Cadena1.Length);
            Console.WriteLine($"Resultado con funcion Substring: {resultado}");
        }
        public void ParsearCadenas()
        {

        }
    }
}

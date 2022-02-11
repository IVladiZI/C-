using System;
using System.Collections.Generic;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 1; Console.WriteLine("Valores : \n" + a + " " + b);
            string cadena = "00000000";
            a += b;
            b -= a;
            //eliminar caracteres
            Console.WriteLine($"Cadena antes \n{cadena}");
            Console.WriteLine($"tamaño \n{cadena.Length}");
            cadena = cadena.Remove(0, cadena.Length-8);
            Console.WriteLine($"Cadena despues \n{cadena}");
            cadena = cadena.Substring(cadena.Length - 8, cadena.Length);
            Console.WriteLine("Con substring \n" + cadena);
            //Asignar valores mediante operadores de suma y resta
            Console.WriteLine("Resultado 1 \n" + a + " " + b);
            a *= b;
            a /= b;
            c = b;
            c %= b;
            //diferente forma de asignacion multiplicacion ,division y resto
            Console.WriteLine("Resultado 2: \n"+ a +" "+ b+" " + c);
            var valorDato = a > b;
            //diferente forma de asignacion multiplicacion ,division y resto
            Console.WriteLine("Resultado 3: \n" + valorDato);
            Objeto a = new Objeto("MARIA", "1238909", 3);
            a.eliminaRepetidos();
            Console.WriteLine(a);
            Conector con = new Conector();

        }


    }
   
}

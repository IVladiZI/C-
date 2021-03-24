using System;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 1; Console.WriteLine("Valores : \n" + a + " " + b);
           
            a += b;
            b -= a;
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
        }
    }
}

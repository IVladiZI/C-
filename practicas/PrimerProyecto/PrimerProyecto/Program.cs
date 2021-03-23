using System;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 0;
            Console.WriteLine("Valores : \n" + a + " " + b);
            a += b;
            b -= a;
            Console.WriteLine("diferente forma de asignacion suma y resta: \n" + a + " " + b);
            a *= b;
            a /= b;
            c = b;
            c %= b;
            Console.WriteLine("diferente forma de asignacion multu y div: \n"+ a +" "+ b+" " + c);
        }
    }
}

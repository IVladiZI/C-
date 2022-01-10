using System;
using System.Collections.Generic;

namespace PrimerProyecto
{
    class Program
    {
        public class Objeto
        {
            string valor1 { get; set; }
            string valor2 { get; set; }
            int valor3 { get; set; }
            public Objeto(string va1, string va2, int i1)
            {
                this.valor1 = va1;
                valor2 = va2;
                valor3 = i1;
            }

            public void eliminaRepetidos()
            {
                List<Objeto> parts = new List<Objeto>();
                Objeto aa = new Objeto("carlos", "12345", 1);
                parts.Add(aa);
                parts.Add(new Objeto("juan", "123", 2));
                parts.Add(new Objeto("carlos", "5554", 1));
                
                List<string> pr = new List<string>();
                pr.Add("123");
                pr.Add("13456");
                pr.Add("77753");
                pr.Add("12345");
                pr.Add("99647");

                foreach (var item in parts)
                {
                    pr.Remove(item.valor2);

                }

                foreach (var item in parts)
                {
                    Console.WriteLine(item.valor1);
                    Console.WriteLine(item.valor2);
                    Console.WriteLine(item.valor3);
                    Console.WriteLine("---------------------------------");
                }
            }
        }
        static void Main(string[] args)
        {
            /*int a = 2, b = 3, c = 1; Console.WriteLine("Valores : \n" + a + " " + b);
            string cadena = "00000000";
            a += b;
            b -= a;
            //eliminar caracteres
            Console.WriteLine("Cadena antes \n" + cadena);
            Console.WriteLine("tamaño \n" + cadena.Length);
            cadena = cadena.Remove(0, cadena.Length-8);
            Console.WriteLine("Cadena despues \n" + cadena);
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
            Console.WriteLine(a);*/
            Conector con = new Conector();

        }


    }
   
}

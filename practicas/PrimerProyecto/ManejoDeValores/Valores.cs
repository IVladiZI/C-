using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeValores
{
    public class Valores
    {

        public int Entero1 { get; set; }
        public int Entero2 { get; set; }
        public int Entero3 { get; set; }
        public string Cadena1 {get; set; }
        public string Cadena2 { get; set; }

        public Valores(int entero1, int entero2, int entero3,string cadena1, string cadena2)
        {
            Entero1 = entero1;
            Entero2 = entero2;
            Entero3 = entero3;
            Cadena1 = cadena1;
            Cadena2 = cadena2;
        }

        public void OperacionesBasicas()
        {
            Console.WriteLine($"Manejo de valores{Environment.NewLine}Suma de Valores {Entero1} y {Entero2}");
            Entero1 += Entero2;
            Console.WriteLine($"Restultado {Entero1}");
            Console.WriteLine($"Manejo de valores{Environment.NewLine}Resta de Valores {Entero2} y {Entero3}");
            Entero2 -= Entero3;
            Console.WriteLine($"Restultado: {Entero2}");
            Console.WriteLine($"Manejo de valores{Environment.NewLine}Multiplicacion de Valores {Entero1} y {Entero2}");
            Entero1 *= Entero2;
            Console.WriteLine($"Restultado: {Entero1}");
            Console.WriteLine($"Manejo de valores{Environment.NewLine}Division de Valores {Entero2} y {Entero3}");
            try
            {
                Entero2 /= Entero3;
                Console.WriteLine($"Restultado: {Entero2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ValidacionDeValores()
        {
            Console.WriteLine($"{Entero1} es mayor que {Entero2}");
            int resultado = Entero1 > Entero2 ? Entero1 : Entero2;
            Console.WriteLine($"Mayor es {resultado}");
            Console.WriteLine($"Mayor de 3 numeros {Entero1}, {Entero2}, {Entero3}");
            resultado = Entero1 > Entero2 && Entero1 > Entero3 ? Entero1 : Entero2 > Entero1 && Entero2 > Entero3 ? Entero2 : Entero3;
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}

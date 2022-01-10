using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Cadenas
{
    public class Cadenas
    {
        string valor1 { get; set; }
        string valor2 { get; set; }
        int valor3 { get; set; }
    }
    public class CadenaYEntero
    {
        string cadena1 { get; set; }
        string cadena2 { get; set; }
        int entero1 { get; set; }
        public CadenaYEntero(string va1, string va2, int i1)
        {
            this.cadena1 = va1;
            cadena2 = va2;
            entero1 = i1;
        }
    }

}

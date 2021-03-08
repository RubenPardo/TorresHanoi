using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {


            Disco d1 = new Disco(1);
            Disco d2 = new Disco(2);
            Disco d3 = new Disco(3);
            Disco d4 = new Disco(4);

            Pila p1 = new Pila("INI");
            Pila p2 = new Pila("FIN");
            Pila p3 = new Pila("AUX");

            Hanoi h = new Hanoi();

            p1.push(d4);
            p1.push(d3);
            p1.push(d2);
            p1.push(d1);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p2.ToString());

            Console.WriteLine("Se completo en: " + h.iterativo(p1.Elementos.Count, p1, p2, p3) + " movimientos");




            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

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

            Pila p1 = new Pila("Pila 1");
            Pila p2 = new Pila("Pila 2");

            Hanoi h = new Hanoi();

            p1.push(d3);
            p1.push(d2);
            p1.push(d1);

            h.mover_disco(p1, p2);
            Console.WriteLine("Top p1: "+p1.Top);
            Console.WriteLine("Top p2: "+p2.Top);

            






            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

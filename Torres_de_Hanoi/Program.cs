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

            Pila p = new Pila("Pila 1");
            Console.WriteLine("Se crea la pila: "+p.Nombre+", esta vacia: "+p.isEmpty());
            Console.WriteLine("Se añade d2");
            p.push(d2);
            Console.WriteLine("El top de la pila es: "+p.Top+ ", esta vacia:" +p.isEmpty());

            Console.WriteLine("Se añade d1");
            p.push(d1);
            Console.WriteLine("El top de la pila es: " + p.Top + ", esta vacia:" + p.isEmpty());

            Disco dBorrado = p.pop();
            Console.WriteLine("Se ha borrado: " + dBorrado.Valor);
            Console.WriteLine("El top de la pila es: " + p.Top + ", esta vacia:" + p.isEmpty());





            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

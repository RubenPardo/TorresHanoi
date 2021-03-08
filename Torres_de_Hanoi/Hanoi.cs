using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            // uno de los dos tiene dicos
            if (!a.isEmpty() || !b.isEmpty()) {
                int topA = a.Top;
                int topB = b.Top;

                if(topA < topB)
                {
                    // mover de B a A
                    Disco dB = b.pop();//quitar de B
                    a.push(dB);// poner en A
                    Console.WriteLine("Se mueve: "+dB.Valor+" de "+b.Nombre+" a "+ a.Nombre);
                }
                else
                {
                    // mover de A a B
                    Disco dA = a.pop();//quitar de A
                    b.push(dA);// poner en B
                    Console.WriteLine("Se mueve: " + dA.Valor + " de " + a.Nombre + " a " + b.Nombre);
                }

            }
            // else no hacer nada
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}

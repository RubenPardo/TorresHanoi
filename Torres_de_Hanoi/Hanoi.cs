using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        
        public void mover_disco(Pila a, Pila b)
        {

            if (a.isEmpty() && !b.isEmpty())
            {
                // mover de B a A
                Disco dB = b.pop();//quitar de B
                a.push(dB);// poner en A
                Console.WriteLine("Se mueve: " + dB.Valor + " de " + b.Nombre + " a " + a.Nombre);
            
            }
            else if(!a.isEmpty() && b.isEmpty())
            {
                // mover de A a B
                Disco dA = a.pop();//quitar de A
                b.push(dA);// poner en B
                Console.WriteLine("Se mueve: " + dA.Valor + " de " + a.Nombre + " a " + b.Nombre);
            }
            else
            {
                int topA = a.Top;
                int topB = b.Top;

                if (topA > topB)
                {
                    // si a tiene una ficha mas grande se tendrá que mover de B a A
                    // mover de B a A
                    Disco dB = b.pop();//quitar de B
                    a.push(dB);// poner en A
                    Console.WriteLine("Se mueve: " + dB.Valor + " de " + b.Nombre + " a " + a.Nombre);
                }
                else
                {
                    // mover de A a B
                    Disco dA = a.pop();//quitar de A
                    b.push(dA);// poner en B
                    Console.WriteLine("Se mueve: " + dA.Valor + " de " + a.Nombre + " a " + b.Nombre);
                }

            }
        }

        /*
         * n = numero de discos
         * */
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            bool haySolucion = false;
            // si n es impar
            if(n%2 == 1)
            {
                while (!haySolucion)
                {
                    mover_disco(ini, fin);
                    movimientos++;
                    haySolucion = comprobar_victoria(n, fin);

                    Console.WriteLine(ini.ToString());
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine(fin.ToString());
                    if (haySolucion) { break; }

                    mover_disco(ini, aux);
                    movimientos++;
                    haySolucion = comprobar_victoria(n, fin);

                    Console.WriteLine(ini.ToString());
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine(fin.ToString());
                    if (haySolucion) { break; }

                    mover_disco(aux, fin);
                    movimientos++;
                    haySolucion = comprobar_victoria(n, fin);

                    Console.WriteLine(ini.ToString());
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine(fin.ToString());
                    if (haySolucion) { break; }


                }
                
            }
            // si n es par
            else
            {
                while (!haySolucion)
                {
                    mover_disco(ini, aux);
                    movimientos++;
                    haySolucion = comprobar_victoria(n, fin);

                    Console.WriteLine(ini.ToString());
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine(fin.ToString());
                    if (haySolucion) { break; }

                    mover_disco(ini, fin);
                    movimientos++;
                    haySolucion = comprobar_victoria(n, fin);

                    Console.WriteLine(ini.ToString());
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine(fin.ToString());
                    if (haySolucion) { break; }

                    mover_disco(aux, fin);
                    movimientos++;
                    haySolucion = comprobar_victoria(n, fin);

                    Console.WriteLine(ini.ToString());
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine(fin.ToString());
                    if (haySolucion) { break; }


                }
            }


            return movimientos;
        }


        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            if (n == 1)
            {
                mover_disco(ini, fin);
                movimientos++;
                Console.WriteLine(ini.ToString());
                Console.WriteLine(aux.ToString());
                Console.WriteLine(fin.ToString());
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                movimientos++;
                Console.WriteLine(ini.ToString());
                Console.WriteLine(aux.ToString());
                Console.WriteLine(fin.ToString());

                recursivo(n - 1, aux, fin, ini);
            }
            

            return movimientos;
        }

        /**
         * Comprueba si la pila fin tiene todas las piezas y ademas 
         * todas estan ordenadas
         */
        private bool comprobar_victoria(int n,Pila fin)
        {
            // si no tiene todas las piezas devolvemos false
            if(fin.Size != n)
            {
                return false;
            }

            bool ordenada = true;
     
            // orden correcto de n,...,3,2,1
            for(int i= fin.Elementos.Count; i<1;i++)
            {
                if (fin.Elementos[i].Valor > fin.Elementos[i - 1].Valor)
                {
                    ordenada = false;
                    break;
                }
            }
            return ordenada;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {

        // a mayor numero mayor tamaño
        private int valor;
        public int Valor {
            get
            {
                return valor;
            }
            set {
                valor = value;
            }
        }

        public Disco(int valor)
        {
            Valor = valor;
        }
        

    }
}

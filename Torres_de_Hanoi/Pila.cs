using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {


        private List<Disco> elementos;
        private int top;// -1 si no hay ninguna

        // numero de discos en la pila
        public int Size {
            get {
                return elementos.Count();
            }
        }
        // disco en el top de la pila, se indica el tamaño
        public int Top { 
            get { return top; } 
            set { top = value; }
        }    
       
        public List<Disco> Elementos { 
            get{
                return elementos;
            }
        }
       

        /* TODO: Implementar métodos */
        public Pila()
        {
            elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            top = d.Value();
            elementos.Add(d);
        }

        public Disco pop()
        {
            Disco discoExtraido = elementos.Last();
            elementos.Remove(discoExtraido);
            // si al borrar el disco esta vacio el top = -1
            if (!isEmpty())
            {
                top = elementos.Last().Value();
            }
            else
            {
                top = -1;
            }
            return discoExtraido;
        }                

        public bool isEmpty()
        {
            return elementos.Count() == 0;
        }

    }
}

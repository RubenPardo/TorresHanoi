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
        private string nombre;


        // nombre de la pila
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

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
        public Pila(string nombre)
        {
            this.nombre = nombre;
            top = -1;
            elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            top = d.Valor;
            elementos.Add(d);
        }

        public Disco pop()
        {
            Disco discoExtraido = elementos.Last();
            elementos.Remove(discoExtraido);
            // si al borrar el disco esta vacio el top = -1
            if (!isEmpty())
            {
                top = elementos.Last().Valor;
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

        public string ToString()
        {
            string res = nombre + ": ";
            if (isEmpty())
            {
                nombre += "Vacia.";
            }
            else
            {
                foreach(Disco d in elementos)
                {
                    nombre+= d.Valor + ", ";
                }
            }

            return res;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_SP2
{
    public class Cola
    {
        // propiedad de la estructura para almacenar el primer nodo 
        public Nodo Primero { get; set; }

        
        public Cola()
        {
            Primero = null;
        }


        
        //INGRESAR -- Método Ingresar, agrega el nodo recibido a la estructura
        public void Ingresar(Nodo nodo)
        {
            //si no hay nodos (Primero pasa a ser el dato que trajimos)
            if (Primero == null) // no hay nodos?
            {
                Primero = nodo;
            }
            else // recorrer los nodos hasta el último
            {
                Nodo aux = Primero; // inicia con el primer nodo de la cola

                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente; // avanza al próximo nodo 
                }
                // enlazar el último con el nodo nuevo
                aux.Siguiente = nodo;
            }

        }

        
        /// Método Eliminar: saca siempre el primer nodo de la cola
        //ELIMINAR NODO
        public Nodo Eliminar()
        {
            Nodo aux = null; // auxiliar para almacenar el nodo a devolver
            if (Primero != null)
            {
                aux = Primero;
                Primero = Primero.Siguiente; // se mueve el apuntador Primero al siguiente nodo
            }
            return aux;
        }


        // LISTAR devuelve la colección de Nodos que contiene la Cola

        public List<Nodo> Listar()
        {   
            // devuelve la colección de nodos obtenida

            //creamos la lista nodos
            List<Nodo> pacientes = new List<Nodo>();

            Nodo aux = Primero; //auxiliar para recorrer los nodos 

            while(aux != null)
            {
                pacientes.Add(aux);//Se guarda el nodo en la lista
                aux = aux.Siguiente; //avanza al otro

            }
            return pacientes;
            
        }


        //BUSCAR NODO
        public bool Buscar(int HistoriaClinica)
        {
            Nodo aux = Primero; // Comienza desde el primer nodo

            // Recorre todos los nodos de la cola
            while (aux != null)
            {
                // Compara el número de historia clínica del nodo actual con el valor buscado
                if (aux.NroHistoriaClinica == HistoriaClinica)
                {
                    return true; // Si lo encuentra, devuelve True
                }
                aux = aux.Siguiente; // Avanza al siguiente nodo
            }

            return false; // Si no lo encuentra, devuelve False
        }

    }
}

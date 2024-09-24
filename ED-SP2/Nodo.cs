using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_SP2
{
    public class Nodo
    {
        public int NroHistoriaClinica { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Nodo Siguiente { get; set; }

        /// <summary>
        /// Constructor de la clase Nodo: inicializa todas las propiedades
        /// </summary>
        public Nodo()
        {
            NroHistoriaClinica = 0;
            Apellido = "";
            Nombre = "";
            Siguiente = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas
{
    public class NodoListas
    {

        public AlimentoParaMascotas Alimento = new AlimentoParaMascotas();
        private NodoListas _siguiente;
        public NodoListas()
        {
            _siguiente = null;
        }
        public NodoListas Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}

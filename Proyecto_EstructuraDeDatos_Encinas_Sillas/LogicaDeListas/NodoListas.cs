using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas
{
    public class NodoListas
    {

        private AlimentoParaMascotas _alimento;
        private NodoListas _siguiente;
        public NodoListas()
        {
            _siguiente = null;
            _alimento = null;
        }
        public NodoListas Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public AlimentoParaMascotas Alimento
        {
            get { return _alimento; }
            set { _alimento = value; }
        }
    }
}

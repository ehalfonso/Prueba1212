using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeColas
{
    class NodoColas
    {
        private NodoColas _siguiente;
        public MascotasEnEspera Mascota = new MascotasEnEspera();

        public NodoColas()
        {
            _siguiente = null;
        }
        public NodoColas Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}

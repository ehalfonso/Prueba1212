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
        private MascotasEnEspera _mascota;

        public NodoColas()
        {
            _siguiente = null;
            _mascota = null;
        }
        public NodoColas Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public MascotasEnEspera Mascota
        {
            get { return _mascota; }
            set { _mascota = value; } 
        }
    }
}

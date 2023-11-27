using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas
{
    public class ListaDeAlimento
    {
        private NodoListas _primero;
        private NodoListas _ultimo;

        public bool ListaVacia()
        {
            return _primero == null ? true : false;
        }
        public bool IngresarAlimento(AlimentoParaMascotas alimentoIngresado)
        {
            try
            {
                NodoListas Nuevo = new NodoListas();
                Nuevo.Alimento = alimentoIngresado;
                if (ListaVacia())
                {
                    _primero = Nuevo;
                    _ultimo = Nuevo;
                    return true;
                }
                else
                {
                    _ultimo.Siguiente = Nuevo;
                    _ultimo = Nuevo;
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        public bool EliminarAlimento()
        {
            try
            {
                if (ListaVacia())
                {
                    return false;
                }
                else if (_primero.Siguiente == null)
                {
                    _primero = null;
                    _ultimo = null;
                    return true;
                }
                else
                {
                    NodoListas Mapeado = _primero;
                    NodoListas Auxiliar = Mapeado;
                    while(Mapeado.Siguiente != null)
                    {
                        Auxiliar = Mapeado;
                        Mapeado = Mapeado.Siguiente;
                    }
                    Auxiliar.Siguiente = null;
                    _ultimo = Auxiliar;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public int ContadorDatosEnLista()
        {
            if (ListaVacia())
            {
                return -1;
            }
            else
            {
                NodoListas Auxiliar = _primero;
                int contador = 1;
                while(Auxiliar.Siguiente != null)
                {
                    contador++;
                    Auxiliar = Auxiliar.Siguiente;
                }
                return contador;
            }
        }

        public AlimentoParaMascotas[] Listar()
        {
            if (ListaVacia())
                return null;
            else
            {
                int cantidadDeElementos = ContadorDatosEnLista();
                AlimentoParaMascotas[] lista = new AlimentoParaMascotas[cantidadDeElementos];
                NodoListas Auxiliar = _primero;
                for(int i = 0; i < cantidadDeElementos; i++)
                {
                    lista[i] = Auxiliar.Alimento;
                    Auxiliar = Auxiliar.Siguiente;
                }
                return lista;
            }
        }
        public void OrdenarAsecendente()
        {
            NodoListas Auxiliar = _primero;
            NodoListas Movimiento = new NodoListas();
            if (!ListaVacia() && ContadorDatosEnLista() > 2)
            {
                while(Auxiliar.Siguiente != null) 
                {
                    if (Auxiliar.Alimento.Precio > Auxiliar.Siguiente.Alimento.Precio)
                    {
                        if (Auxiliar == _primero)
                        {
                            Movimiento = Auxiliar.Siguiente;
                            Auxiliar.Siguiente = Movimiento.Siguiente;
                            Movimiento.Siguiente = Auxiliar;
                            _primero = Movimiento;
                            Auxiliar = _primero;
                        }
                        else if(Auxiliar.Siguiente == _ultimo)
                        {
                            Movimiento = Auxiliar.Siguiente; // = ultimo
                            Movimiento.Siguiente = Auxiliar;
                            Auxiliar.Siguiente = null; // Apuntando a null, porque se volvera el ultimo
                            _ultimo = Auxiliar;
                        }
                        else
                        {
                            Movimiento = Auxiliar.Siguiente;
                            Auxiliar.Siguiente = Movimiento.Siguiente;
                            Movimiento.Siguiente = Auxiliar;
                            Auxiliar = Auxiliar.Siguiente;
                        }
                    }
                    else
                    {
                        Auxiliar = Auxiliar.Siguiente;
                    }
                }
            }
        }
        public void OrdenarDescendente()
        {
            NodoListas Auxiliar = _primero;
            NodoListas Movimiento = new NodoListas();
            if (!ListaVacia() && ContadorDatosEnLista() > 2)
            {
                while (Auxiliar.Siguiente != null)
                {
                    if (Auxiliar.Alimento.Precio < Auxiliar.Siguiente.Alimento.Precio)
                    {
                        if (Auxiliar == _primero)
                        {
                            Movimiento = Auxiliar.Siguiente;
                            Auxiliar.Siguiente = Movimiento.Siguiente;
                            Movimiento.Siguiente = Auxiliar;
                            _primero = Movimiento;
                            Auxiliar = _primero;
                        }
                        else if (Auxiliar.Siguiente == _ultimo)
                        {
                            Movimiento = Auxiliar.Siguiente; // = ultimo
                            Movimiento.Siguiente = Auxiliar;
                            Auxiliar.Siguiente = null; // Apuntando a null, porque se volvera el ultimo
                            _ultimo = Auxiliar;
                        }
                        else
                        {
                            Movimiento = Auxiliar.Siguiente;
                            Auxiliar.Siguiente = Movimiento.Siguiente;
                            Movimiento.Siguiente = Auxiliar;
                            Auxiliar = Auxiliar.Siguiente;
                        }
                    }
                    else
                    {
                        Auxiliar = Auxiliar.Siguiente;
                    }
                }
            }
        }

        //public bool ModificarAlimento(string nombreAlimento)
        //{

        //}

    }
}

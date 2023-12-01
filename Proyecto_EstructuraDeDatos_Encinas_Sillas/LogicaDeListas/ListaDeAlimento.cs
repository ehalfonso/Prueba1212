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
            if (!ListaVacia())
            {
                int enLista = ContadorDatosEnLista();
                if(enLista >= 2)
                {
                    NodoListas Auxiliar = _primero;
                    AlimentoParaMascotas[] arregloTemporal = new AlimentoParaMascotas[enLista];
                    AlimentoParaMascotas temporal = new AlimentoParaMascotas();
                    for(int i = 0; i < enLista; i++)
                    {
                        arregloTemporal[i] = Auxiliar.Alimento;
                        Auxiliar = Auxiliar.Siguiente;
                    }
                    for(int i = 0; i < enLista - 1; i++)
                    {
                        for(int j = 0; j < enLista - i - 1; j++)
                        {
                            if (arregloTemporal[j].Precio > arregloTemporal[j + 1].Precio)
                            {
                                temporal = arregloTemporal[j];
                                arregloTemporal[j] = arregloTemporal[j + 1];
                                arregloTemporal[j + 1] = temporal;
                            }
                        }
                    }
                    _primero = null;
                    _ultimo = null;
                    for(int i = 0; i < enLista; i++)
                    {
                        IngresarAlimento(arregloTemporal[i]);
                    }
                }
            }
        }
        public void OrdenarDescendente()
        {
            if (!ListaVacia())
            {
                int enLista = ContadorDatosEnLista();
                if (enLista >= 2)
                {
                    NodoListas Auxiliar = _primero;
                    AlimentoParaMascotas[] arregloTemporal = new AlimentoParaMascotas[enLista];
                    AlimentoParaMascotas temporal = new AlimentoParaMascotas();
                    for (int i = 0; i < enLista; i++)
                    {
                        arregloTemporal[i] = Auxiliar.Alimento;
                        Auxiliar = Auxiliar.Siguiente;
                    }
                    for (int i = 0; i < enLista - 1; i++)
                    {
                        for (int j = 0; j < enLista - i - 1; j++)
                        {
                            if (arregloTemporal[j].Precio < arregloTemporal[j + 1].Precio)
                            {
                                temporal = arregloTemporal[j];
                                arregloTemporal[j] = arregloTemporal[j + 1];
                                arregloTemporal[j + 1] = temporal;
                            }
                        }
                    }
                    _primero = null;
                    _ultimo = null;
                    for (int i = 0; i < enLista; i++)
                    {
                        IngresarAlimento(arregloTemporal[i]);
                    }
                }
            }
        }

        //public bool ModificarAlimento(string nombreAlimento)
        //{

        //}

    }
}

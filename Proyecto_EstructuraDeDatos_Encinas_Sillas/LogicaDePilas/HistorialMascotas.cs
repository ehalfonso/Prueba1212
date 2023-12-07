using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDePilas
{
    public class RegistroAtencion
    {
        public Stack<RegistroMascota> pilaMascotas;

        public RegistroAtencion()
        {
            pilaMascotas = new Stack<RegistroMascota>();
        }

        public void AgregarMascota(string nombre, DateTime horaLlegada, DateTime horaAtencion, string notas)
        {
            RegistroMascota nuevaMascota = new RegistroMascota
            {
                Nombre = nombre,
                HoraLlegada = horaLlegada,
                HoraAtencion = horaAtencion,
                Notas = notas
            };

            pilaMascotas.Push(nuevaMascota);
        }

        public void ModificarMascota(int index,string nombre, DateTime horaLlegada, DateTime horaAtencion, string notas)
        {
            if (pilaMascotas.Count > 0)
            {
                RegistroMascota mascotaActual = pilaMascotas.Peek();
                mascotaActual.Nombre = nombre;
                mascotaActual.HoraLlegada = horaLlegada;
                mascotaActual.HoraAtencion = horaAtencion;
                mascotaActual.Notas = notas;
            }
        }

        public void EliminarMascota()
        {
            if (pilaMascotas.Count > 0)
            {
                pilaMascotas.Pop();
            }
        }

        public RegistroMascota[] ObtenerMascotasAtendidas()
        {
            return pilaMascotas.ToArray();
        }
        public void ListarMascotas(DataGridView dataGridView)
        {
            // Limpiar el DataGridView
            dataGridView.Rows.Clear();

            // Obtener las mascotas desde la lógica de pilas
            var mascotas = new List<RegistroMascota>(pilaMascotas);

            foreach (var mascota in mascotas)
            {
                dataGridView.Rows.Add(mascota.Nombre, mascota.HoraLlegada, mascota.HoraAtencion, mascota.Notas);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

//Servicio para gestionar las rutinas de entrenamiento
namespace Rutinas_Entrenamiento.Services
{
    public class RutinaService
    {
        public List<Rutinas> rutinas = new List<Rutinas>// Lista de rutinas de entrenamiento
    {
    new Rutinas { Id = 1, Nombre = "Sentadilla", Descripcion = "Rutina para piernas", Duracion = 30 },
    new Rutinas { Id = 2, Nombre = "Curl de Barra", Descripcion = "Rutina para brazos", Duracion = 45 },
    };

        public void AñadirRutina(Rutinas rutina)// Método para agregar una nueva rutina
        {
            rutina.Id = rutinas.Max(r => r.Id) + 1;
            rutinas.Add(rutina);
        }

        public void QuitarRutina(string nombre)// Método para eliminar una rutina por su nombre
        {
            var rutinaAEliminar = rutinas.FirstOrDefault(r => r.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            if (rutinaAEliminar != null)
            {
                rutinas.Remove(rutinaAEliminar);
            }
        }

        public Rutinas ObtenerRutina(int id)// Método para obtener una rutina por su id
        {
            return rutinas.FirstOrDefault(r => r.Id == id);
        }
    }
}
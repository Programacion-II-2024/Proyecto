// TareaMainPageViewModel.cs
using System.Collections.ObjectModel;
using Proyecto.Models;

namespace Proyecto.ViewModels
{
    public class TareaMainPageViewModel : BindableObject
    {
        public ObservableCollection<Tarea> Tareas { get; set; }

        public TareaMainPageViewModel()
        {
            Tareas = new ObservableCollection<Tarea>();
        }

        public void AgregarTarea(Tarea nuevaTarea)
        {
            Tareas.Add(nuevaTarea);
        }

        public void EliminarTarea(Tarea tarea)
        {
            Tareas.Remove(tarea);
        }
    }
}

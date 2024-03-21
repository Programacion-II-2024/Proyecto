// TareaMainPage.xaml.cs
using Microsoft.Maui.Controls;
using Proyecto.Models;
using System.Collections.ObjectModel;

namespace Proyecto.Views
{
    public partial class TareaMainPage : ContentPage
    {
        private ObservableCollection<Tarea> tareas = new ObservableCollection<Tarea>();

        public TareaMainPage()
        {
            InitializeComponent();
            listaTareas.ItemsSource = tareas;
        }

        private async void AgregarTarea_Clicked(object sender, EventArgs e)
        {
            var nombre = await DisplayPromptAsync("Nueva Tarea", "Ingrese el nombre de la tarea:");
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                var nuevaTarea = new Tarea { Nombre = nombre };
                tareas.Add(nuevaTarea);
            }
        }
    }
}

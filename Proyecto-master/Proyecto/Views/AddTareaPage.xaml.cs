// AddTareaPage.xaml.cs
using Microsoft.Maui.Controls;
using Proyecto.Models;

namespace Proyecto.Views
{
    public partial class AddTareaPage : ContentPage
    {
        public AddTareaPage()
        {
            InitializeComponent();
        }

        private async void AgregarTarea_Clicked(object sender, EventArgs e)
        {
            // Crear una nueva tarea con el nombre ingresado
            var nuevaTarea = new Tarea { Nombre = nombreEntry.Text };

            // Aquí puedes agregar lógica adicional para guardar la nueva tarea en tu sistema de almacenamiento

            // Por ahora, simplemente puedes cerrar esta página y regresar a la página principal
            await Navigation.PopAsync();
        }
    }
}

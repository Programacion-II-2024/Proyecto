// EditTareaPage.xaml.cs
using Microsoft.Maui.Controls;
using Proyecto.Models;

namespace Proyecto.Views
{
    public partial class EditTareaPage : ContentPage
    {
        private Tarea tarea;

        public EditTareaPage(Tarea tarea)
        {
            InitializeComponent();
            this.tarea = tarea;

            // Mostrar el nombre de la tarea en el Entry
            nombreEntry.Text = tarea.Nombre;
        }

        private void GuardarCambios_Clicked(object sender, EventArgs e)
        {
            // Actualizar el nombre de la tarea con el valor del Entry
            tarea.Nombre = nombreEntry.Text;

            // Aquí puedes agregar lógica adicional para guardar otros cambios en la tarea, si es necesario

            // Cerrar la página y regresar a la página anterior
            Navigation.PopAsync();
        }
    }
}

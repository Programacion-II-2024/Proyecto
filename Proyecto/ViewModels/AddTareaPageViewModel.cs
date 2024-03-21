using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Proyecto.Models;
using Proyecto.Services;

namespace Proyecto.ViewModels
{
    public partial class AddTareaPageViewModel : ObservableObject 
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private string descripcion;

       

    }
}

﻿using CommunityToolkit.Mvvm.ComponentModel;
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

        [ObservableProperty]
        private string estadoTarea;

          
        private readonly TareaService _tareaService;

        public AddTareaPageViewModel()
        {
            _tareaService = new TareaService();
           
        }

        public AddTareaPageViewModel(Tarea tarea)
        {
            _tareaService = new TareaService();
            Nombre = tarea.Nombre;
            Descripcion = tarea.Descripcion;
            EstadoTarea = tarea.EstadoTarea;
            Id = tarea.Id;
        }

        [RelayCommand]
        private async Task AddUpdate()
        {
            try
            {
                Tarea tarea = new Tarea
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    EstadoTarea = EstadoTarea,
                    Id = Id
                };



                if (Validar(tarea))
                {
                    if (Id == 0)
                    {
                        _tareaService.Insert(tarea);
                    }
                    else
                    {
                        _tareaService.Update(tarea);
                    }
                    await App.Current.MainPage.Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }

        private bool Validar(Tarea tarea)
        {
            try
            {
                if (string.IsNullOrEmpty(tarea.Nombre))
                {
                    Alerta("ADVERTENCIA", "Escriba el nombre");
                    return false;
                }
                else if (string.IsNullOrEmpty(tarea.Descripcion))
                {
                    Alerta("ADVERTENCIA", "Escriba la descripción");
                    return false;
                }
                else if (string.IsNullOrEmpty(tarea.EstadoTarea))
                {
                    Alerta("ADVERTENCIA", "Seleccione el estado de la tarea");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
                return false;
            }
        }


        private void Alerta(string tipo, string mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current.MainPage.DisplayAlert(tipo, mensaje, "Aceptar"));
        }
    }
}

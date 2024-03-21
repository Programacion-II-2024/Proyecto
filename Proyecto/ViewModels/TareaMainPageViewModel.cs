using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Proyecto.Models;
using Proyecto.Services;
using Proyecto.Views;
using System.Collections.ObjectModel;

namespace Proyecto.ViewModels;

public partial class TareaMainPageViewModel : ObservableObject
{
	[ObservableProperty]
	private ObservableCollection<Tarea> tareaCollection = new ObservableCollection<Tarea>();
	
	private readonly TareaService _tareaService;
	public TareaMainPageViewModel()
	{
		_tareaService = new TareaService();
	}

	public void GetAll()
	{
		var getAll = _tareaService.GetAll();
		if (getAll?.Count > 0) 
		{ 
			tareaCollection.Clear();
			foreach (var tarea in getAll)
			{
				tareaCollection.Add(tarea);
			}
		}

	}

	[RelayCommand]
	private async Task GoToAddTareaPage()
	{
		await App.Current!.MainPage.Navigation.PushAsync(new AddTareaPage());
	}


	[RelayCommand]
	private async Task SelectTarea(Tarea tarea)
	{
		try
		{
			string res = await App.Current!.MainPage!.DisplayActionSheet("Operación","Cancelar",null,"Actualizar","Eliminar");

			switch (res)
			{
				case "Actualizar":
					await App.Current!.MainPage!.Navigation.PushAsync(new AddTareaPage(tarea)); 
					break;
				case "Eliminar":
					bool respuesta = await App.Current!.MainPage!.DisplayAlert("Eliminar Tarea", "¿Desea Eliminar la taea", "Si", "No");
					if (respuesta)
					{
						int del = _tareaService.Delete(tarea);
						if (del > 0)
						{
							TareaCollection.Remove(tarea);
						}
					}
					break;
				}

		} catch (Exception ex)
		{
			Alerta("Error", ex.Message);
		}
	}
	private void Alerta(String Tipo, String Mensaje)
	{
		MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Tipo,Mensaje,"Aceptar"));
	}

}
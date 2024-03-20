using Proyecto.Models;
using Proyecto.ViewModels;

namespace Proyecto.Views;

public partial class AddTareaPage : ContentPage
{
	private AddTareaPageViewModel _viewModel;
	public AddTareaPage()
	{
		InitializeComponent();
		_viewModel = new AddTareaPageViewModel();
		this.BindingContext = _viewModel;
	}

	public AddTareaPage(Tarea tarea)
	{
		InitializeComponent();
		_viewModel = new AddTareaPageViewModel(tarea);
		this.BindingContext = _viewModel;
	}

}
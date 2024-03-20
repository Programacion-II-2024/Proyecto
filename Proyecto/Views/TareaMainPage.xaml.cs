using Proyecto.ViewModels;
namespace Proyecto.Views;

public partial class TareaMainPage : ContentPage
{
	private TareaMainPageViewModel _viewModel;
	public TareaMainPage()
	{
		InitializeComponent();
		_viewModel = new TareaMainPageViewModel();
		this.BindingContext = _viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		_viewModel.GetAll();
    }

}
using Proyecto.Views;

namespace Proyecto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TareaMainPage());
        }
    }
}

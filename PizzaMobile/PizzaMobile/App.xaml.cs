using PizzaMobile.View;

namespace PizzaMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PizzaPage1();
        }
    }
}

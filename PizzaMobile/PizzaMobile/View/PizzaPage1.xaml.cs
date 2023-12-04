using PizzaMobile.ViewModel;
namespace PizzaMobile.View;

public partial class PizzaPage1 : ContentPage
{
	public PizzaPage1()
	{
		InitializeComponent();
        BindingContext = new PizzaViewModel();
    }
}
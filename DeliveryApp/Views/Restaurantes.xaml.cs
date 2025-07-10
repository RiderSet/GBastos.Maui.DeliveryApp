using DeliveryApp.ViewModels;

namespace DeliveryApp.Views;

public partial class Restaurantes : ContentPage
{
	public Restaurantes()
	{
		InitializeComponent();

        /*
		 * Conectar a página (View) com a classe ViewModel
		 * Dessa forma a página irá conseguir acessar qualquer
		 * propriedade contida na classe ViewModel
		 */
        BindingContext = new RestaurantesViewModel();
	}
}
using DeliveryApp.ViewModels;

namespace DeliveryApp.Views;

public partial class Restaurantes : ContentPage
{
	public Restaurantes()
	{
		InitializeComponent();

        /*
		 * Conectar a p�gina (View) com a classe ViewModel
		 * Dessa forma a p�gina ir� conseguir acessar qualquer
		 * propriedade contida na classe ViewModel
		 */
        BindingContext = new RestaurantesViewModel();
	}
}
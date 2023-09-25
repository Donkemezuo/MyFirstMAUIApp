using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp;

public partial class MainPage : ContentPage
{

	// Using dependency injection to pass the view model to the view
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; 
	}

}



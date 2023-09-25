namespace MyFirstMAUIApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// Registering the detail page in the routing system
		Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
	}
}


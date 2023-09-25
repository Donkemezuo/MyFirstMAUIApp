using Microsoft.Extensions.Logging;
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Registering the viewModel in the dependency system. 
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

		// Registering the details page - transient creates object for use and removes from memory when object is no longer in use
		builder.Services.AddTransient<DetailsPage>();
		builder.Services.AddTransient<DetailsViewModel>();

        return builder.Build();
	}
}


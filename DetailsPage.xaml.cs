
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(DetailsViewModel vm) {
        InitializeComponent();
        BindingContext = vm;
    }
}

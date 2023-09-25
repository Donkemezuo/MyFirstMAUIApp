using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIApp.ViewModel;


	public partial class MainViewModel : ObservableObject

{
    public MainViewModel() {
        Items = new ObservableCollection<string>();

    }

    // An observable list of items
    [ObservableProperty]
    ObservableCollection<String> items; 

    /// <Observable Object gives us built-in functions to automatically handle property change operations>
 
    [ObservableProperty]
    string text;

    [RelayCommand]
    // Creating a method - add an item 
    void add() {

        /// Checking to see if the string is empty
        if (string.IsNullOrWhiteSpace(Text))
            return;

        // adding string to observable list 
        Items.Add(Text);

        // setting the string to empty;
        Text = string.Empty;
    }
    


    //// A getter and setter to update changes 
    //public string Text {
    //	get => text;
    //	set {
    //		text = value;
    //		OnPropertyChanged(nameof(Text));
    //			}

    //}
    //// This will notifify .NET MAUI when we want to update the interface 
    //public event PropertyChangedEventHandler PropertyChanged;

    //void OnPropertyChanged(string name) =>
    //	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

}


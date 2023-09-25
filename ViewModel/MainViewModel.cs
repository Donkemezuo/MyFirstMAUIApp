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
    void Add() {

        /// Checking to see if the string is empty
        if (string.IsNullOrWhiteSpace(Text))
            return;

        // adding string to observable list 
        Items.Add(Text);

        // setting the string to empty;
        Text = string.Empty;
    }

    [RelayCommand]
    //Creating the delete function
    void Delete(string item) {
        // checking to see if the list contains the item 
        if (Items.Contains(item)) {
            Items.Remove(item);
        }
    }


    [RelayCommand]
    // Tap action - navigating to the details view
    async Task Tap(string selectedItem) {
        await Shell.Current.GoToAsync(nameof(DetailsPage));
    }
}


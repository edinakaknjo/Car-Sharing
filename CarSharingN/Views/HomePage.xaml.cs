using CarSharingN.ViewModels;

namespace CarSharingN.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomePageViewModel();
    }

    public async void Potrazite_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(GeneratorPage)}");
    }
}
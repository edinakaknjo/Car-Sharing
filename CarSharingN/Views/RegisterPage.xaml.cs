using CarSharingN.ViewModels;
using CarSharingN.Models;

namespace CarSharingN.Views;


public partial class RegisterPage : ContentPage
{
    public RegisterPage(RegisterViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    
    //private async void Confirm_Clicked(object sender, EventArgs e)
    //{
    //    if (entrySifra.Text == entryPotvrdiSifru.Text)
    //    {
    //        User user = new User
    //        {
    //            //Ime = entryIme.Text,
    //            //Prezime = entryPrezime.Text,
    //            //Username = entryUsername.Text,
    //            Sifra = entrySifra.Text,
    //            Email = entryEmail.Text
    //        };

    //        await Navigation.PushModalAsync(new LoginPageView(user));


    //        //await Shell.Current.GoToAsync("//HomePage");
    //    }
    //    else
    //    {
    //        await DisplayAlert("Error", "The password confirmation does not match.", "OK");
    //    }
    //}

    private async void Button_Clicked_Back(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DashboardView");
    }
}
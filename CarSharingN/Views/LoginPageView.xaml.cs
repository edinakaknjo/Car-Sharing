using CarSharingN.ViewModels;
using CarSharingN.Models;

namespace CarSharingN.Views;

public partial class LoginPageView : ContentPage
{
    //public User registrovanikorisnik;
    public LoginPageView(LoginViewModel viewmodel)
    {
        InitializeComponent();
        BindingContext = viewmodel;
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    if (registrovanikorisnik.Username == entryUsername.Text && registrovanikorisnik.Sifra == entrySifra.Text)
    //    {
    //        await Shell.Current.GoToAsync("//HomePage");
    //    }
    //    //await Shell.Current.GoToAsync("//HomePage");
    //    else
    //    {
    //        await DisplayAlert("Bad Credentials", "Wrong username or password", "OK");
    //    }
    //}

    private async void Button_Clicked_Back(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DashboardView");
    }
    private async void SignUp_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//RegisterPage");
    }

}
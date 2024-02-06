using CarSharingN.Models;

namespace CarSharingN.Views;

public partial class DashboardView : ContentPage
{
    //Models.User newUser = new Models.User
    //{
    //    Ime = "Ime",
    //    Prezime = "Prezime",
    //    Username = "Username",
    //    Sifra = "123456",
    //    Email = "Email"
    //};
    public DashboardView()
    {
        InitializeComponent();
    }

    public async void Login_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPageView)}");
    }
    public async void Register_Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
    }
}
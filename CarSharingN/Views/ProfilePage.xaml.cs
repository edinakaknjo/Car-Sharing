namespace CarSharingN.Views;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();

        Ime.Text = "Ime Prezime";
        Lokacija.Text = "Zenica, Bosna i Hercegovina";
        Email.Text = "ovajemail@gmail.com";
    }
}
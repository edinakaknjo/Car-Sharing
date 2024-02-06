namespace CarSharingN.Views;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }
    public async void LogOut_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DashboardView");
    }
}
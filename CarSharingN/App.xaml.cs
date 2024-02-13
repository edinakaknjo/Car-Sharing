using CarSharingN.ViewModels;
namespace CarSharingN;

public partial class App : Application
{
    public static HomePageViewModel HomePageViewModel { get; } = new HomePageViewModel();

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
        MainPage.BindingContext = HomePageViewModel;
    }

    protected override async void OnStart()
    {
        await Shell.Current.GoToAsync("//IntroScreenView");

        base.OnStart();
    }
}

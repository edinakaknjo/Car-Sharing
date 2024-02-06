using CarSharingN.ViewModels;

namespace CarSharingN.Views;

public partial class IntroScreenView : ContentPage
{
	public IntroScreenView()
	{
        InitializeComponent();
        this.BindingContext = new IntroScreenViewModel();
    }
}
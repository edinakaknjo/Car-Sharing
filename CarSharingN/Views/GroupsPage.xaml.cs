using CarSharingN.ViewModels;

namespace CarSharingN.Views;

public partial class GroupsPage : ContentPage
{
    public GroupsPage()
    {
        InitializeComponent();
        BindingContext = new GroupsViewModel();
    }

}
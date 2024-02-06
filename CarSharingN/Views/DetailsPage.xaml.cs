using CarSharingN.Models;
namespace CarSharingN.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(Automobil _auto)
    {
        InitializeComponent();
        putovanjeName.Text = _auto.Name;
        location.Text = _auto.Location;
        category.Text = _auto.Category;
        description.Text = _auto.Description;
        ImageUrl.Source = _auto.ImageUrl;
         
    }
    private async void Favorite_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Favorites", "Added to favorites", "OK");

    }
}
using System.Collections.Generic;
using CarSharingN.Models;
using CarSharingN.Views;
using Microsoft.Maui.Controls;

namespace CarSharingN.Views
{
    public partial class ResultsPage : ContentPage
    {
        public ResultsPage(List<Automobil> filteredAutomobils)
        {
            InitializeComponent();

            // Set the filtered automobils as the ListView's ItemSource
            filteredAutomobilsListView.ItemsSource = filteredAutomobils;
        }
    }
}

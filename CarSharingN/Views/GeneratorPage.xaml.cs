using System;
using System.Collections.Generic;
using System.Linq;
using CarSharingN.ViewModels;
using CarSharingN.Models;
using CarSharingN.Views;
using Microsoft.Maui.Controls;

namespace CarSharingN.Views
{
    public partial class GeneratorPage : ContentPage
    {
        private List<string> selectedFuelTypes = new List<string>();
        private HomePageViewModel viewModel;

        public GeneratorPage()
        {
            InitializeComponent();

            viewModel = new HomePageViewModel();
        }

        private void CategoryCheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkbox = sender as CheckBox;
            var fuelType = checkbox?.BindingContext as string;

            if (e.Value)
            {
                selectedFuelTypes.Add(fuelType);
            }
            else
            {
                selectedFuelTypes.Remove(fuelType);
            }
        }

        private void GenerateCarsButton_Clicked(object sender, EventArgs e)
        {
            var selectedFuelTypes = GetSelectedCheckboxValues(Category1Checkbox, Category2Checkbox, Category3Checkbox);

            var selectedCategories = GetSelectedCheckboxValues(Category4Checkbox, Category5Checkbox, Category6Checkbox);

            var filteredAutomobils = FilterAutomobilsByFuelAndCategory(selectedFuelTypes, selectedCategories);

            Navigation.PushAsync(new ResultsPage(filteredAutomobils));
        }

        private List<string> GetSelectedCheckboxValues(params CheckBox[] checkboxes)
        {
            return checkboxes
                .Where(checkbox => checkbox.IsChecked)
                .Select(checkbox => checkbox.BindingContext as string)
                .ToList();
        }

        private List<Automobil> FilterAutomobilsByFuelAndCategory(List<string> selectedFuelTypes, List<string> selectedCategories)
        {
            return viewModel.Automobili
                .Where(a => selectedFuelTypes.Contains(a.Fuel) && selectedCategories.Contains(a.Category))
                .ToList();
        }

    }
}

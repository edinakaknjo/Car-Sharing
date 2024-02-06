using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarSharingN.ViewModels;
using CarSharingN.Models;


namespace CarSharingN.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Models.Automobil> Automobil { get; private set; } = new ObservableCollection<Models.Automobil>();

        public HomePageViewModel()
        {
            AddAutomobil();
        }

        void AddAutomobil()
        {
            Automobil.Add(new Models.Automobil
            {
                Name = "Volvo XC90",
                Location = "2km away",
                Category = "SUV",
                Duration = "2021 HIBRID",
                ImageUrl = "https://miro.medium.com/v2/resize:fit:1200/1*rcF5Y_X8gBRkXeaqk5ZHZA@2x.jpeg",
                IsFavorite = true,
                Description = "Volvo XC90 T8 A RECHARGE Inscription Expression 7 sjedišta",
                Motor = new List<string> { "2.0", "286kW" },
                Condition = new List<string> { "53.000 km" },
                Aditional = new List<string> { "Navi Tech", "Sensus", "Apple Carplay", "Android Auto" }
            });
            Automobil.Add(new Models.Automobil
            {
                Name = "BMW 320",
                Location = "3km away",
                Category = "Sedan",
                Duration = "2020 DIZEL",
                ImageUrl = "https://images.wapcar.my/file1/6fa840c679024682b0042f4251495782_1125x630.jpg",
                IsFavorite = true,
                Description = "Bmw G20 M paket 2020 god. Automatik",
                Motor = new List<string> { "2.0", "105kW" },
                Condition = new List<string> { "93.000 km" },
                Aditional = new List<string> { "Laser svjetla", "BMW Live Cockpit Plus" }
            });
            Automobil.Add(new Models.Automobil
            {
                Name = "Audi A6",
                Location = "5km away",
                Category = "Sedan",
                Duration = "2020 DIZEL",
                ImageUrl = "https://images.cars.com/cldstatic/wp-content/uploads/audi-s6-2020-01-angle--exterior--front--grey.jpg",
                IsFavorite = true,
                Description = "Audi A6 dizel",
                Motor = new List<string> { "2.0", "150kW" },
                Condition = new List<string> { "74.000 km" },
                Aditional = new List<string> { " S line Sport", "Android Auto" }
            });
            Automobil.Add(new Models.Automobil
            {
                Name = "Volvo S60",
                Location = "2km away",
                Category = "Sedan",
                Duration = "2021 BENZIN",
                ImageUrl = "https://www.vicariousmag.com/wp-content/uploads/2021/07/2021-Volvo-S60-1-750x400.jpg",
                IsFavorite = true,
                Description = "Volvo S60 T4 A INSCRIPTION",
                Motor = new List<string> { "2.0", "140kW" },
                Condition = new List<string> { "87.000 km" },
                Aditional = new List<string> { " City Safety", "Tempomat", "Apple Carplay", "Android Auto" }
            });
            Automobil.Add(new Models.Automobil
            {
              Name = "Volvo XC90",
                Location = "2km away",
                Category = "SUV",
                Duration = "2021 HIBRID",
                ImageUrl = "https://miro.medium.com/v2/resize:fit:1200/1*rcF5Y_X8gBRkXeaqk5ZHZA@2x.jpeg",
                IsFavorite = true,
                Description = "Volvo XC90 T8 A RECHARGE Inscription Expression 7 sjedišta",
                Motor = new List<string> { "2.0", "286kW" },
                Condition = new List<string> { "53.000 km", "Batteries", "Camera", "Charger" },
                Aditional = new List<string> { "Navi Tech", "Sensus", "Apple Carplay", "Android Auto" }
            });
            Automobil.Add(new Models.Automobil
            {
                Name = "BMW X6",
                Location = "1km away",
                Category = "SUV",
                Duration = "2017 DIZEL",
                ImageUrl = "https://surreyhillsmotorcompany.co.uk/wp-content/uploads/2023/05/photo-output_0-4-876x535.jpeg",
                IsFavorite = true,
                Description = "BMW X6 F16 2017",
                Motor = new List<string> { "3.0", "190kW" },
                Condition = new List<string> { "153.000 km" },
                Aditional = new List<string> { "Full M paket", "Keyless Go" }
            });
        }



        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

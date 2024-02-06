using CarSharingN.Models;
using CarSharingN.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarSharingN.ViewModels
{
    public class IntroScreenViewModel : BaseViewModel
    {

        #region Properties

        private string _buttonText = ">>";
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
        }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value, onChanged: (() =>
            {
                if (value == IntroScreens.Count - 1)
                {
                    ButtonText = "GO";
                }
                else
                {
                    ButtonText = ">>";
                }
            }));
        }

        public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel>();
        #endregion

        public IntroScreenViewModel()
        {
            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Započnite vožnju",
                IntroDescription = "u automobilu svojih snova",
                IntroImage = "https://cdn3.iconfinder.com/data/icons/basic-2-1/128/a_head_heart_love_romantic_-512.png"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Jedinstvena prilika",
                IntroDescription = "u Vašoj blizini",
                IntroImage = "https://cdn.icon-icons.com/icons2/2217/PNG/512/augmented_reality_car_transport_analysis_icon_134261.png"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Jednostavno i brzo",
                IntroDescription = "ključ u ruke",
                IntroImage = "https://cdn-icons-png.flaticon.com/512/8692/8692785.png"
            });
        }


        public ICommand NextCommand => new Command(async () =>
        {
            if (Position >= IntroScreens.Count - 1)
            {
                await AppShell.Current.GoToAsync($"//{nameof(DashboardView)}");
            }
            else
            {
                Position += 1;
            }
        });


    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSharingN.Models;

namespace CarSharingN.ViewModels
{
    public class GroupsViewModel
    {
        public ObservableCollection<Grupa> Grupe { get; private set; } = new ObservableCollection<Grupa>();

        public GroupsViewModel()
        {
            AddGrupe();
        }
        public void AddGrupe()
        {
            Grupe.Add(new Grupa
            {
                Id = 1,
                Name = "Gorivo",
                Items = new List<string> { "DIZEL", "BENZIN","PLIN", "BENZIN-PLIN", "HIBRID", "ELEKTRIČNI"}
            });
            Grupe.Add(new Grupa
            {
                Id = 2,
                Name = "Motor",
                Items = new List<string> { "1.2", "1.4", "1.6", "1.8", "2.0", "3.0" }
            });
            Grupe.Add(new Grupa
            {
                Id = 3,
                Name = "Tip",
                Items = new List<string> { "SUV", "Limuzina", "Karavan", "Cabrio", "Kombi", "Kamion"}
            });
            Grupe.Add(new Grupa
            {
                Id = 4,
                Name = "Dodatna oprema",
                Items = new List<string> { "Navigacija", "LED", "Android Auto", "Apple Car", "4x4", "S-Line" }
            });
            
            Grupe.Add(new Grupa
            {
                Id = 5,
                Name = "Boja",
                Items = new List<string> { "Crna", "Siva", "Bijela", "Crvena", "Zelena", "Plava" }
            });

            

        }
    }
}

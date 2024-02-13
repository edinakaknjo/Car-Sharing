using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingN.Models
{
    public class Automobil
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Fuel { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFavorite { get; set; }
        public string Description { get; set; }
        public List<string> Motor { get; set; }
        public List<string> Condition { get; set; }
        public List<string> Aditional { get; set; }


    }
}

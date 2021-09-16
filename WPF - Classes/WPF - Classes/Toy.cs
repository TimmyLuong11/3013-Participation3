using System;
using System.Collections.Generic;
using System.Text;

namespace WPF___Classes
{
    class Toy
    {
        public string Manufacturer { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Image = string.Empty;
            Aisle = string.Empty;
        }

        public string GetAisle()
        {
            return $"{Manufacturer[0].ToString().ToUpper()}{Price}";
        }
        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }

    }
}

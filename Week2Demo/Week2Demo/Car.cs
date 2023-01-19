using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Week2Demo
{
    internal class Car : Vehicle, IRental, ICar
    {

        public int Mpg { get; set; }
        public string RentalId { get; set; }
        public string RentalName { get; set; }
        public int PricePerDay { get; set; }
        public bool RentalEnabled { get; set; } = true;
        public void Renting()
        {
            if (RentalEnabled)
            {
                Console.WriteLine($"You rented a {RentalName}");
                RentalEnabled = false;
            }

        }
    }
}

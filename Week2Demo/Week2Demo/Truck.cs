using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demo
{
    internal class Truck : Vehicle, IRental
    {
        public int MaximumLoad { get; set; }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demo
{
    internal interface IRental
    {
        public string RentalId { get; set; }
        public string RentalName { get; set;}
        public int PricePerDay { get; set; }

        public bool RentalEnabled { get; set; }

        public void Renting();
    }
}

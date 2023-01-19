namespace Week2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRental> myRentals = new List<IRental>();
            myRentals.Add(new Car{RentalId = "0001", RentalName = "GMC Acadia", PricePerDay = 100, CarType = "SUV"});
            myRentals.Add(new Carseat { RentalId = "0002", RentalName = "Gerber seat", PricePerDay = 20 });

            foreach (IRental r in myRentals)
            {
                r.Renting();

            }
        }
    }
}
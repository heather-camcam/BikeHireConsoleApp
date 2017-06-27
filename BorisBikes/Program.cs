using System;

namespace BorisBikes
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeStation = new BikeStation();
            var person = new Person();

            while (true){
                
                Console.WriteLine("Press '1' to take a bike out and '2' to dock it. Followed by the 'Enter' key.");

                var response = Console.ReadLine();

                if (response == "1")
                {
                    person.RemoveBike();
                }

                if (response == "2")
                {
                    person.DockBike();
                }
            }
        }
    }
}

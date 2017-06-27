using System;
using System.Collections.Generic;
using System.Linq;

namespace BorisBikes
{
    public class Person
    {
        private BikeStation _bikeStation;
        private List<BikeModel> _myBikes;

        public Person()
        {
            _myBikes = new List<BikeModel> { };
            _bikeStation = new BikeStation();
        }

        public void RemoveBike()
        {
            if (_bikeStation.HasBikes)
            {
                var bike = _bikeStation.ReleaseBike();
                _myBikes.Add(bike);

                Console.WriteLine($"You now have {_myBikes.Count} bikes hired out");
            }
            else
            {
                Console.WriteLine("No bikes here my friend. Dock one of your existing bikes first");
            }
        }

        public void DockBike()
        {
            if (_myBikes.Any())
            {
                var bike = _myBikes[_myBikes.Count - 1];
                _myBikes.Remove(bike);

                _bikeStation.LockBike(bike);

                Console.WriteLine($"You now have {_myBikes.Count} bikes hired out");
            }
            else
            {
                Console.WriteLine("You don't have any bikes to dock");
            }
        }
    }
}

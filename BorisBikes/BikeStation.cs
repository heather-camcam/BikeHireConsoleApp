using System;
using System.Collections.Generic;
using System.Linq;

namespace BorisBikes
{
    public class BikeStation
    {
        private List<BikeModel> _dockedBikes;
        private const int _capacity = 10;

        public bool HasBikes;

        public BikeStation()
        {
            _dockedBikes = new List<BikeModel> { };
            FillUpBikeStation();
        }

        public BikeModel ReleaseBike()
        {
            var releasedBike = _dockedBikes[_dockedBikes.Count - 1];

            if (!releasedBike.IsWorking)
            {
                FixBike(releasedBike);
            }

            _dockedBikes.Remove(releasedBike);
            UpdateBikeAvailability();

            Console.WriteLine("Congrats! You've hired a bike");

            return releasedBike;
        }

        public void LockBike(BikeModel removedBike)
        {
            _dockedBikes.Add(removedBike);
            Console.WriteLine($"Your bike has been successfully docked.");
        }

        private void FillUpBikeStation()
        {
            for (int i = 0; i < _capacity; i++)
            {
                var bike = new BikeModel() { IsWorking = false };
                _dockedBikes.Add(bike);
            }

            HasBikes = true;
        }

        private void FixBike(BikeModel brokenBike)
        {
            _dockedBikes.Remove(brokenBike);

            var _bikeGarage = new BikeGarage();
            var fixedBike = _bikeGarage.FixBike(brokenBike);

            _dockedBikes.Add(fixedBike);
        }

        private void UpdateBikeAvailability()
        {
            if (_dockedBikes.Any())
                HasBikes = true;
            else
                HasBikes = false;
        }
    }
}

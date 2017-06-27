namespace BorisBikes
{
    class BikeGarage
    {
        public BikeModel FixBike(BikeModel bike)
        {
            bike.IsWorking = true;
            return bike;
        }
    }
}

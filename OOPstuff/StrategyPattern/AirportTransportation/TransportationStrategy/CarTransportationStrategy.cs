namespace OOPstuff.StrategyPattern.AirportTransportation.TransportationStrategy {

    class CarTransportationStrategy : ITransportation {

        private readonly double TimeMultiplier = 0.9;

        private int CalculateTravelTime(int travelTime) => (int)(travelTime * TimeMultiplier);

        public int EstimateArrivalTime(int distanceToAirport) => CalculateTravelTime(distanceToAirport);
    }
}

namespace OOPstuff.StrategyPattern.AirportTransportation.TransportationStrategy {

    class BusTransportationStrategy : ITransportation {

        private readonly int BusStopsToDistination = 4;

        private int CalculateTravelTime(int distanceToDestination) {
            return (int)(BusStopsToDistination * 0.75) + (distanceToDestination * 3);
        }

        public int EstimateArrivalTime(int distanceToAirport) => CalculateTravelTime(distanceToAirport);
    }
}

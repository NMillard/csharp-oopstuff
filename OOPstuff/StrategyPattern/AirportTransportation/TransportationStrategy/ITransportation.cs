namespace OOPstuff.StrategyPattern.AirportTransportation.TransportationStrategy {

    interface ITransportation {
        int EstimateArrivalTime(int distanceToAirport);
    }
}

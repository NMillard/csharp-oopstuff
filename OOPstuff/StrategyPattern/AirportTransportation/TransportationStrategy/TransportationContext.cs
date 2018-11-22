using System;

namespace OOPstuff.StrategyPattern.AirportTransportation.TransportationStrategy {

    public class TransportationContext {
        ITransportation transportationStrategy;

        public int ProvideTransportTimeEstimate(
            string transportationMode,
            int distanceToDestination
            ) {
            transportationStrategy = TransportationPicker(transportationMode);

            return transportationStrategy.EstimateArrivalTime(distanceToDestination);
        }

        private ITransportation TransportationPicker(string mode) {
            switch (mode) {
                case "CAR":
                    return new CarTransportationStrategy();
                case "BUS":
                    return new BusTransportationStrategy();
                default: throw new Exception("Mode not supported.");
            }
        }
    }
}

using System;

namespace OOPstuff.StatePattern.CarState {
    class StopState : ICarState {

        private string Status = "Engine is turned off";

        public ICarState ChangeEngineStatus(IDriveable driveable) {
            driveable.SetState(new StartState());
            Console.WriteLine("Engine has started.");

            return this;
        }

        public string EngineStatus() {
            return Status;
        }
    }
}

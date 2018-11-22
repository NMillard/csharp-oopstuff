using System;

namespace OOPstuff.StatePattern.CarState {

    class StartState : ICarState {
        private string Status = "Engine is running.";

        public ICarState ChangeEngineStatus(IDriveable driveable) {
            driveable.SetState(new StopState());
            Console.WriteLine("Engine has stopped:");

            return this;
        }

        public string EngineStatus() {
            return Status;
        }
    }
}

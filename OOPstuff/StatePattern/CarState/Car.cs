using System;

namespace OOPstuff.StatePattern.CarState {

    class Car : IDriveable {
        private ICarState State;

        private string Make { get; set; }

        public Car() {
            State = new StopState();
        }

        public string GetMake() => this.Make;

        public IDriveable StartEngine() {
            State.ChangeEngineStatus(this);
            return this;
        }

        public IDriveable StopEngine() {
            State.ChangeEngineStatus(this);
            return this;
        }

        public IDriveable Status() {
            Console.WriteLine(State.EngineStatus());

            return this;
        }

        public IDriveable SetState(ICarState state) {
            Console.WriteLine("State has changed!");
            State = state;

            return this;
        }
    }
}

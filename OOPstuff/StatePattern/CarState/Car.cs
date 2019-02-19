using System;

namespace OOPstuff.StatePattern.CarState {

    class Car : IDriveable {
        private ICarState _state;

        private string Make { get; set; }

        public Car() {
            _state = new StopState();
        }

        public string GetMake() => this.Make;

        public IDriveable StartEngine() {
            _state.ChangeEngineStatus(this);
            return this;
        }

        public IDriveable StopEngine() {
            _state.ChangeEngineStatus(this);
            return this;
        }

        public IDriveable Status() {
            Console.WriteLine(_state.EngineStatus());

            return this;
        }

        public IDriveable SetState(ICarState state) {
            Console.WriteLine("State has changed!");
            _state = state;

            return this;
        }
    }
}

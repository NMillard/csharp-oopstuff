namespace OOPstuff.StatePattern.CarState {

    interface ICarState {
        ICarState ChangeEngineStatus(IDriveable driveable);
        string EngineStatus();
    }
}

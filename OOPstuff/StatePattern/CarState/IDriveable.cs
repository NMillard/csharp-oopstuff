using System;

namespace OOPstuff.StatePattern.CarState {

    interface IDriveable {
        IDriveable StartEngine();
        IDriveable StopEngine();
        IDriveable Status();

        IDriveable SetState(ICarState state);
    }
}

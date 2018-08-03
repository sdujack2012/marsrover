using System;

namespace MarsRover.Interface
{
    public interface ILocation
    {
        int X { get; }
        int Y { get; }

        ILocation MoveXForward();
        ILocation MoveYForward();
        ILocation MoveXBackward();
        ILocation MoveYBackward();
    }
}

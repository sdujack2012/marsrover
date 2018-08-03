using System;

namespace MarsRover.Interface
{
    public interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();
        ILocation GetForwardLocation(ILocation Location);
    }
}

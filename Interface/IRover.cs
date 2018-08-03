using System;

namespace MarsRover.Interface
{
    public interface IRover
    {
        IDirection CurrentDirection { get; }
        ILocation CurrentLocation { get; }
        void TurnLeft();
        void TurnRight();
        void MoveForward();
        void SetDirection(IDirection direction);
        void SetLocation(ILocation location);
    }
}

using System;

namespace MarsRover.Interface
{
    public interface IDirection
    {
        void TurnLeft(IRover rover);
        void TurnRight(IRover rover);
        void MoveForward(IRover rover);
    }
}

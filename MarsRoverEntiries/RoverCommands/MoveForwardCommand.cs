using System;
using MarsRover.Interface;

namespace MarsRover.Command
{
    public class MoveForwardCommand : RoverCommand
    {
        public MoveForwardCommand(IRover rover)
        {
            _rover = rover;
        }

        public override void Execute()
        {
            _rover.MoveForward();
        }
    }
}

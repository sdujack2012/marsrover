using System;
using MarsRover.Interface;

namespace MarsRover.Command
{
    public class TurnLeftCommand : RoverCommand
    {
        public TurnLeftCommand(IRover rover)
        {
            _rover = rover;
        }

        public override void Execute()
        {
            _rover.TurnLeft();
        }
    }
}

using System;
using MarsRover.Interface;

namespace MarsRover.Command
{
    public class TurnRightCommand : RoverCommand
    {
        public TurnRightCommand(IRover rover)
        {
            _rover = rover;
        }

        public override void Execute()
        {
            _rover.TurnRight();
        }
    }
}

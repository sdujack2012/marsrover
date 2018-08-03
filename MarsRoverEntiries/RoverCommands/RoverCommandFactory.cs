using System;
using MarsRover.Interface;

namespace MarsRover.Command
{
    public class RoverCommandFactory : CommandFactory
    {
        public override RoverCommand GetRoverCommand(IRover rover, char commandChar)
        {
            switch (commandChar)
            {
                case 'L':
                    return new TurnLeftCommand(rover);
                case 'R':
                    return new TurnRightCommand(rover);
                case 'M':
                    return new MoveForwardCommand(rover);
                default:
                    throw new ArgumentException("Unknown command");
            }
        }
    }
}

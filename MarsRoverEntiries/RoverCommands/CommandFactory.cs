using System;
using MarsRover.Interface;

namespace MarsRover.Command
{
    public abstract class CommandFactory
    {
        public abstract RoverCommand GetRoverCommand(IRover rover, char commandChar);
    }
}

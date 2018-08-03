using System;
using MarsRover.Interface;

namespace MarsRover.Command
{
    public abstract class RoverCommand : ICommand
    {
        protected IRover _rover;
        public abstract void Execute();
    }
}

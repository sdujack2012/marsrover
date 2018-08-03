using System;
using MarsRover.Interface;

namespace MarsRover.Direction
{
    public abstract class DirectionFactory
    {
        public abstract IDirection GetDirection(string direction);
    }
}
using System;
using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class RoverDirectionFactory : DirectionFactory
    {
        public override IDirection GetDirection(string direction)
        {
            switch (direction)
            {
                case "N":
                    return new North();
                case "W":
                    return new West();
                case "S":
                    return new South();
                case "E":
                    return new East();
                default:
                    throw new ArgumentException("Invalid direction");
            }
        }
    }
}
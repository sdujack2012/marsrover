using System;
using MarsRover.Interface;
using MarsRover.Location;
using MarsRover.Direction;

namespace MarsRover.Rover
{
    public class Rover : IRover
    {
        public IDirection CurrentDirection { get; private set; }
        public ILocation CurrentLocation { get; private set; }
        private ILocation _upperRight;

        private RoverLocationFactory _roverLocationFactory = new RoverLocationFactory();
        private RoverDirectionFactory _roverDirectionFactory = new RoverDirectionFactory();

        public Rover(string direction, int x, int y, int upperRightX, int upperRightY)
        {
            CurrentDirection = _roverDirectionFactory.GetDirection(direction);
            CurrentLocation = _roverLocationFactory.GetLocation(x, y);
            _upperRight = _roverLocationFactory.GetLocation(upperRightX, upperRightY);
        }

        public void TurnLeft()
        {
            CurrentDirection.TurnLeft(this);
        }

        public void TurnRight()
        {
            CurrentDirection.TurnRight(this);
        }

        public void MoveForward()
        {
            CurrentDirection.MoveForward(this);
            CheckIfAlive();
        }

        public void SetDirection(IDirection direction)
        {
            CurrentDirection = direction;
        }

        public void SetLocation(ILocation location)
        {
            CurrentLocation = location;
        }

        public override string ToString()
        {
            return $"{CurrentLocation.ToString()} {CurrentDirection.ToString()}";
        }

        private void CheckIfAlive()
        {
            if (CurrentLocation.X < 0 || CurrentLocation.Y < 0 || CurrentLocation.X > _upperRight.X || CurrentLocation.Y > _upperRight.Y)
            {
                throw new Exception("The rover has gone too far and might have been kidnapped by aliens");
            }
        }
    }
}
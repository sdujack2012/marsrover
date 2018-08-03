using MarsRover.Interface;

namespace MarsRover.Rover
{
    public class Rover : IRover
    {
        private IDirection _currentDirection;
        private ILocation _currentLocation;

        public Rover(IDirection direction, ILocation Location)
        {
            _currentDirection = direction;
            _currentLocation = Location;
        }

        public void TurnLeft()
        {
            _currentDirection = _currentDirection.TurnLeft();
        }

        public void TurnRight()
        {
            _currentDirection = _currentDirection.TurnRight();
        }

        public void MoveForward()
        {
            _currentLocation = _currentDirection.GetForwardLocation(_currentLocation);
        }

        public override string ToString()
        {
            return $"{_currentLocation.ToString()} {_currentDirection.ToString()}";
        }
    }
}
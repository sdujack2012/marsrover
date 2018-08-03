using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class West : IDirection
    {
        public IDirection TurnLeft()
        {
            return new South();
        }

        public IDirection TurnRight()
        {
            return new North();
        }

        public ILocation GetForwardLocation(ILocation Location)
        {
            return Location.MoveXBackward();
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
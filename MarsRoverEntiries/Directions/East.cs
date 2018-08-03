using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class East : IDirection
    {
        public IDirection TurnLeft()
        {
            return new North();
        }

        public IDirection TurnRight()
        {
            return new South();
        }

        public ILocation GetForwardLocation(ILocation Location)
        {
            return Location.MoveXForward();
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
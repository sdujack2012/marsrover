using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class North : IDirection
    {
        public IDirection TurnLeft()
        {
            return new West();
        }

        public IDirection TurnRight()
        {
            return new East();
        }

        public ILocation GetForwardLocation(ILocation Location)
        {
            return Location.MoveYForward();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
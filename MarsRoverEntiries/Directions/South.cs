using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class South : IDirection
    {
        public IDirection TurnLeft()
        {
            return new East();
        }

        public IDirection TurnRight()
        {
            return new West();
        }

        public ILocation GetForwardLocation(ILocation Location)
        {
            return Location.MoveYBackward();
        }

        public override string ToString()
        {
            return "S";
        }
    }
}
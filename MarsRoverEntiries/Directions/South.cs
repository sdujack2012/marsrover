using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class South : IDirection
    {
        public void TurnLeft(IRover rover)
        {
            rover.SetDirection(new East());
        }

        public void TurnRight(IRover rover)
        {
            rover.SetDirection(new West());
        }

        public void MoveForward(IRover rover)
        {
            rover.SetLocation(rover.CurrentLocation.MoveYBackward());
        }

        public override string ToString()
        {
            return "S";
        }
    }
}
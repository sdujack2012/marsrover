using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class North : IDirection
    {
        public void TurnLeft(IRover rover)
        {
            rover.SetDirection(new West());
        }

        public void TurnRight(IRover rover)
        {
            rover.SetDirection(new East());
        }

        public void MoveForward(IRover rover)
        {
            rover.SetLocation(rover.CurrentLocation.MoveYForward());
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
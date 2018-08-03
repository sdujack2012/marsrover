using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class East : IDirection
    {
        public void TurnLeft(IRover rover)
        {
            rover.SetDirection(new North());
        }

        public void TurnRight(IRover rover)
        {
            rover.SetDirection(new South());
        }

        public void MoveForward(IRover rover)
        {
            rover.SetLocation(rover.CurrentLocation.MoveXForward());
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
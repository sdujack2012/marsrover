using MarsRover.Interface;

namespace MarsRover.Direction
{
    public class West : IDirection
    {
        public void TurnLeft(IRover rover)
        {
            rover.SetDirection(new South());
        }

        public void TurnRight(IRover rover)
        {
            rover.SetDirection(new North());
        }

        public void MoveForward(IRover rover)
        {
            rover.SetLocation(rover.CurrentLocation.MoveXBackward());
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
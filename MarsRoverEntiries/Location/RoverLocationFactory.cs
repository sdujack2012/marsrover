using MarsRover.Interface;

namespace MarsRover.Location
{
    public class RoverLocationFactory : LocationFactory
    {
        public override ILocation GetLocation(int x, int y)
        {
            return new Location(x, y);
        }
    }
}
using MarsRover.Interface;

namespace MarsRover.Location
{
    public abstract class LocationFactory
    {
        public abstract ILocation GetLocation(int x, int y);
    }
}
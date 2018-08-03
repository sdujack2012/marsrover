using MarsRover.Interface;

namespace MarsRover.Location
{
    public class Location : ILocation
    {
        public int X { get; }
        public int Y { get; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public ILocation MoveXForward()
        {
            return new Location(X + 1, Y);
        }

        public ILocation MoveYForward()
        {
            return new Location(X, Y + 1);
        }

        public ILocation MoveXBackward()
        {
            return new Location(X - 1, Y);
        }

        public ILocation MoveYBackward()
        {
            return new Location(X, Y - 1);
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}
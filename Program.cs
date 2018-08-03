using System;
using System.IO;
using System.Linq;
using MarsRover.Command;
using MarsRover.Rover;
using MarsRover.Direction;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"./testInput.txt");

            var rightConnerXAndY = file.ReadLine()?.Split(" ");

            if (rightConnerXAndY == null || rightConnerXAndY.Length != 2)
            {
                Console.WriteLine("Invalid input");
            }

            var rightConnerX = int.Parse(rightConnerXAndY[0]);
            var rightConnerY = int.Parse(rightConnerXAndY[1]);
            var directionFactory = new RoverDirectionFactory();
            var commandFactory = new RoverCommandFactory();

            string[] LocationAndDirection;
            while ((LocationAndDirection = file.ReadLine()?.Split(" ")) != null)
            {
                var x = int.Parse(LocationAndDirection[0]);
                var y = int.Parse(LocationAndDirection[1]);
                var Location = new Location(x, y);
                var direction = directionFactory.GetDirection(LocationAndDirection[2]);
                var rove = new MarsRover.Rover.Rover(direction, Location);
                var commandString = file.ReadLine();
                foreach (char commandChar in commandString.ToCharArray())
                {
                    var command = commandFactory.GetRoverCommand(rove, commandChar);
                    command.Execute();
                }
                Console.WriteLine(rove.ToString());
            }
        }
    }
}

using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication;

public class RoverFactory
{
    public static Rover.Rover CreateRover(string roverPosition)
    {
        var positions = roverPosition.Split(' ');
        var x = int.Parse(positions[0]);
        var y = int.Parse(positions[1]);
        var position = new Position(x, y);
        var directionStringCommand = positions[2];
        var direction = DirectionFactory.CreateDirection(directionStringCommand);
        return new Rover.Rover(position, direction);
    }
}
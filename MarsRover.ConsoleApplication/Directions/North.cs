using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication.Directions;

public class North : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X, position.Y + 1);
    public IDirection TurnRight() => new East();
    public IDirection TurnLeft() => new West();
    public string AsStringCommand() => "N";

}
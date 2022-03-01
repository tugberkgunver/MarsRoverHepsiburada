using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication.Directions;

public class West : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X - 1, position.Y);
    public IDirection TurnRight() => new North();
    public IDirection TurnLeft() => new South();
    public string AsStringCommand() => "W";

}
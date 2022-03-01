using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication.Directions;

public class East : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X + 1, position.Y);
    public IDirection TurnRight() => new South();
    public IDirection TurnLeft() => new North();
    public string AsStringCommand() => "E";

}
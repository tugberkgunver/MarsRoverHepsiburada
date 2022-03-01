using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication.Directions;

public class South : IDirection
{
    public Position MoveForward(Position position) => new Position(position.X, position.Y - 1);
    public IDirection TurnRight() => new West();
    public IDirection TurnLeft() => new East();
    public string AsStringCommand() => "S";

}

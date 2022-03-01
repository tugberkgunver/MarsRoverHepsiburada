using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication;

public interface IDirection
{
    Position MoveForward (Position position);
    string AsStringCommand();
    IDirection TurnRight();
    IDirection TurnLeft();
}
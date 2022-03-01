using MarsRover.ConsoleApplication.Commands;

namespace MarsRover.ConsoleApplication.Rover;

public class Rover
{
    public readonly Position _position;
    public readonly IDirection _direction;

    public Rover(Position position, IDirection direction)
    {
        _position = position;
        _direction = direction;
    }

    public Rover Apply(ICommand command) => ApplyCommand((dynamic) command);

    private Rover ApplyCommand(TurnRightCommand c) => new Rover(_position, _direction.TurnRight());

    private Rover ApplyCommand(TurnLeftCommand c) => new Rover(_position, _direction.TurnLeft());

    private Rover ApplyCommand(MoveForwardCommand c) => new Rover(_direction.MoveForward(_position), _direction);
}
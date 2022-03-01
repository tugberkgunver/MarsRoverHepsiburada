namespace MarsRover.ConsoleApplication.Commands;

public class CommandFactory
{
    public static ICommand CreateCommand(char c) =>
        c switch
        {
            'M' => new MoveForwardCommand(),
            'R' => new TurnRightCommand(),
            'L' => new TurnLeftCommand(),
            _ => throw new NotSupportedException($"Command {c} is not supported")
        };
}
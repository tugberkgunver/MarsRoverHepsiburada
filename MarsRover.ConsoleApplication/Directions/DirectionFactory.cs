using MarsRover.ConsoleApplication.Directions;

namespace MarsRover.ConsoleApplication;

public class DirectionFactory
{
    public static IDirection CreateDirection(string direction) =>
        direction switch
        {
            "N" => new North(),
            "W" => new West(),
            "E" => new East(),
            "S" => new South(),
            _ => throw new NotSupportedException($"Direction {direction} is not supported")
        };
}
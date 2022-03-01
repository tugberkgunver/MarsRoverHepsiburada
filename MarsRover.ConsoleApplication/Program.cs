using MarsRover.ConsoleApplication.Plateau;
using MarsRover.ConsoleApplication.Rover;

List<string> input = new List<string>();
string line;

while ((line = Console.ReadLine()) != null && line != "")
{
    input.Add(line);
}

var grid_size = input.First();
var rover_count = (input.Count - 1) / 2;
var plateau =  new Plateau(grid_size);

var rover_index = 1;
for (var i = 0; i < rover_count; i++)
{
    var rover_position = input[rover_index + i];
    var rover = new MarsRover.ConsoleApplication.MarsRover(rover_position);
    if (!plateau.ValidateRoverPosition(rover._rover._position))
    {
        Console.WriteLine("Rover Position Error!");
    }
    rover_index += 1;
    var rover_movement = input[rover_index + i];
    var final_rover_position = rover.Execute(rover_movement);
    if (plateau.ValidateRoverPosition(rover._rover._position))
    {
        Console.WriteLine(final_rover_position);
    }
    else
    {
        Console.WriteLine("Rover Movement Error!");
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.ConsoleApplication.Commands;

namespace MarsRover.ConsoleApplication
{
    public class MarsRover
    {
        public Rover.Rover _rover;

        public MarsRover(string roverPosition)
        {
            _rover = RoverFactory.CreateRover(roverPosition);
        }

        public string Execute(string stringCommands)
        {

            var commands = stringCommands.ToCharArray().Select(CommandFactory.CreateCommand).ToList();
            commands.ForEach(c => _rover = _rover.Apply(c));

            return $"{_rover._position.X} {_rover._position.Y} {_rover._direction.AsStringCommand()}";
        }
    }
}

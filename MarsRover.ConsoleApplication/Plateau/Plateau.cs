using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication.Plateau
{
    public class Plateau
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Plateau(string plateauSize)
        {
            var inputs = plateauSize.Split(' ');
            int.TryParse(inputs[0], out var width);
            int.TryParse(inputs[1], out var height);

            Width = width;
            Height = height;
        }

        public bool ValidateRoverPosition(Position roverPosition)
        {
            var x = roverPosition.X >= 0 && roverPosition.X <= Width;
            var y = roverPosition.Y >= 0 && roverPosition.Y <= Height;
            return x && y;
        }
    }
}
